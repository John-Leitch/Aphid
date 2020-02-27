
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
                                    public const string Country = "HR";
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
                            
                                        var cur = (Math.Abs(43.53333 - lat) + Math.Abs(16.46667 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(45.0775 - lat) + Math.Abs(18.6975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.75 - lat) + Math.Abs(15.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.95111 - lat) + Math.Abs(17.11417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.52111 - lat) + Math.Abs(16.55917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14278 - lat) + Math.Abs(13.90889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.80188 - lat) + Math.Abs(18.80879 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09417 - lat) + Math.Abs(16.07083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.44944 - lat) + Math.Abs(16.43361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95611 - lat) + Math.Abs(16.24611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.87639 - lat) + Math.Abs(16.875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86667 - lat) + Math.Abs(15.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58917 - lat) + Math.Abs(17.95028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16687 - lat) + Math.Abs(17.14485 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28444 - lat) + Math.Abs(16.40917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.22056 - lat) + Math.Abs(15.17361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.78944 - lat) + Math.Abs(15.82528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.69083 - lat) + Math.Abs(18.03806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45194 - lat) + Math.Abs(16.40917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25556 - lat) + Math.Abs(16.03639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85639 - lat) + Math.Abs(15.80778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6 - lat) + Math.Abs(15.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.3975 - lat) + Math.Abs(17.05694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.06454 - lat) + Math.Abs(16.16765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83361 - lat) + Math.Abs(16.06361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81444 - lat) + Math.Abs(15.97798 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71978 - lat) + Math.Abs(15.9088 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.43139 - lat) + Math.Abs(16.88972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16361 - lat) + Math.Abs(18.15444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.11578 - lat) + Math.Abs(15.22514 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.08083 - lat) + Math.Abs(15.91111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.02944 - lat) + Math.Abs(15.915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.94611 - lat) + Math.Abs(16.61333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.5 - lat) + Math.Abs(16.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.94444 - lat) + Math.Abs(15.72528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68333 - lat) + Math.Abs(16.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35161 - lat) + Math.Abs(19.00225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.87778 - lat) + Math.Abs(17.23222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.43389 - lat) + Math.Abs(18.505 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22444 - lat) + Math.Abs(13.635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.26472 - lat) + Math.Abs(15.2325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14917 - lat) + Math.Abs(13.60528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21056 - lat) + Math.Abs(18.40556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.90828 - lat) + Math.Abs(16.3983 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.85167 - lat) + Math.Abs(15.41917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05012 - lat) + Math.Abs(14.52976 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.20583 - lat) + Math.Abs(17.37111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35305 - lat) + Math.Abs(15.86563 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36861 - lat) + Math.Abs(15.07833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88333 - lat) + Math.Abs(16.42167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21861 - lat) + Math.Abs(17.57778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.18222 - lat) + Math.Abs(16.67083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.07583 - lat) + Math.Abs(14.6725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.1875 - lat) + Math.Abs(17.41917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30639 - lat) + Math.Abs(18.55806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.265 - lat) + Math.Abs(16.52 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.98139 - lat) + Math.Abs(18.92722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.47806 - lat) + Math.Abs(16.45778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.50999 - lat) + Math.Abs(16.18704 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.54806 - lat) + Math.Abs(16.67889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32361 - lat) + Math.Abs(15.69861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50556 - lat) + Math.Abs(15.58 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.95944 - lat) + Math.Abs(13.85167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27556 - lat) + Math.Abs(18.60972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.76083 - lat) + Math.Abs(15.78278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61778 - lat) + Math.Abs(17.54778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45944 - lat) + Math.Abs(18.57417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32944 - lat) + Math.Abs(13.75861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09028 - lat) + Math.Abs(16.325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.56861 - lat) + Math.Abs(18.61389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27639 - lat) + Math.Abs(13.72083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.345 - lat) + Math.Abs(18.46222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.06194 - lat) + Math.Abs(16.18306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83194 - lat) + Math.Abs(17.38389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.06722 - lat) + Math.Abs(16.99 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.30306 - lat) + Math.Abs(15.08528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23333 - lat) + Math.Abs(16.58333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.83611 - lat) + Math.Abs(13.86222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28833 - lat) + Math.Abs(18.80472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.48972 - lat) + Math.Abs(16.11306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33611 - lat) + Math.Abs(16.14944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.09806 - lat) + Math.Abs(14.10694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.75139 - lat) + Math.Abs(18.06306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61083 - lat) + Math.Abs(16.57444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28333 - lat) + Math.Abs(16.24111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41611 - lat) + Math.Abs(17.79444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3355 - lat) + Math.Abs(14.27562 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.69111 - lat) + Math.Abs(18.32167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52361 - lat) + Math.Abs(18.10944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.51729 - lat) + Math.Abs(14.50479 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93556 - lat) + Math.Abs(16.93417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46 - lat) + Math.Abs(15.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85 - lat) + Math.Abs(16.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.67333 - lat) + Math.Abs(17.10917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.75028 - lat) + Math.Abs(17.0475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.45 - lat) + Math.Abs(16.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29444 - lat) + Math.Abs(16.71306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.64528 - lat) + Math.Abs(17.32833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.12644 - lat) + Math.Abs(15.89297 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6825 - lat) + Math.Abs(16.95389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76667 - lat) + Math.Abs(15.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.8016 - lat) + Math.Abs(17.06551 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78752 - lat) + Math.Abs(16.28139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73639 - lat) + Math.Abs(16.03111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6 - lat) + Math.Abs(16.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.15611 - lat) + Math.Abs(18.39306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7125 - lat) + Math.Abs(16.07556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90667 - lat) + Math.Abs(17.18083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63333 - lat) + Math.Abs(16.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45444 - lat) + Math.Abs(17.66139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.96333 - lat) + Math.Abs(16.7225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6275 - lat) + Math.Abs(18.77056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20917 - lat) + Math.Abs(16.41917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30444 - lat) + Math.Abs(16.33778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66083 - lat) + Math.Abs(18.41861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.74056 - lat) + Math.Abs(16.18972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.43139 - lat) + Math.Abs(13.52389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66278 - lat) + Math.Abs(18.66194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.13083 - lat) + Math.Abs(15.10306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.53056 - lat) + Math.Abs(15.76556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57139 - lat) + Math.Abs(18.67583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25667 - lat) + Math.Abs(16.235 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.39694 - lat) + Math.Abs(15.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.64944 - lat) + Math.Abs(16.14361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.65 - lat) + Math.Abs(16.66917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41585 - lat) + Math.Abs(16.59605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89361 - lat) + Math.Abs(17.39556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.97111 - lat) + Math.Abs(15.41139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2 - lat) + Math.Abs(16.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.07694 - lat) + Math.Abs(15.74722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.02972 - lat) + Math.Abs(16.10167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.46667 - lat) + Math.Abs(16.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.27222 - lat) + Math.Abs(17.05444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41917 - lat) + Math.Abs(18.89917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.0075 - lat) + Math.Abs(17.275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.5125 - lat) + Math.Abs(16.25167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29472 - lat) + Math.Abs(16.39889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.1875 - lat) + Math.Abs(18.14222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26139 - lat) + Math.Abs(18.25306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.61833 - lat) + Math.Abs(16.72417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.75547 - lat) + Math.Abs(15.74444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22139 - lat) + Math.Abs(14.67861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40278 - lat) + Math.Abs(17.66333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.98456 - lat) + Math.Abs(16.60034 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.165 - lat) + Math.Abs(19.15194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25145 - lat) + Math.Abs(15.3255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34 - lat) + Math.Abs(16.44222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37028 - lat) + Math.Abs(18.795 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22333 - lat) + Math.Abs(16.88472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.29306 - lat) + Math.Abs(15.97222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46056 - lat) + Math.Abs(16.43583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23333 - lat) + Math.Abs(19.09194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38639 - lat) + Math.Abs(18.42028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.91892 - lat) + Math.Abs(15.42 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.74389 - lat) + Math.Abs(15.70972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21806 - lat) + Math.Abs(13.83944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.01924 - lat) + Math.Abs(15.47441 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.80417 - lat) + Math.Abs(15.64333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.49806 - lat) + Math.Abs(18.74722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30083 - lat) + Math.Abs(13.62528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35639 - lat) + Math.Abs(16.28194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08806 - lat) + Math.Abs(13.88361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18361 - lat) + Math.Abs(13.86833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28333 - lat) + Math.Abs(15.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96667 - lat) + Math.Abs(16.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52694 - lat) + Math.Abs(16.375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24694 - lat) + Math.Abs(16.32528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28444 - lat) + Math.Abs(16.60417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.79833 - lat) + Math.Abs(15.78056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33556 - lat) + Math.Abs(16.74194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78306 - lat) + Math.Abs(18.775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.38583 - lat) + Math.Abs(16.47694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.7975 - lat) + Math.Abs(14.72472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.38417 - lat) + Math.Abs(16.55083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3685 - lat) + Math.Abs(16.56702 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.07611 - lat) + Math.Abs(17.8775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26806 - lat) + Math.Abs(17.77722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.05 - lat) + Math.Abs(15.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.1575 - lat) + Math.Abs(15.4075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.79972 - lat) + Math.Abs(17.49917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.12528 - lat) + Math.Abs(17.18611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18333 - lat) + Math.Abs(16.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52778 - lat) + Math.Abs(16.55417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36444 - lat) + Math.Abs(16.21417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70843 - lat) + Math.Abs(15.91674 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22611 - lat) + Math.Abs(18.42389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50222 - lat) + Math.Abs(16.28833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51868 - lat) + Math.Abs(16.38418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36889 - lat) + Math.Abs(16.415 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.83861 - lat) + Math.Abs(17.69639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.5025 - lat) + Math.Abs(16.52222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18389 - lat) + Math.Abs(17.54083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.09556 - lat) + Math.Abs(18.64028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.80472 - lat) + Math.Abs(16.72028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36833 - lat) + Math.Abs(16.49611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.19 - lat) + Math.Abs(18.24778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23083 - lat) + Math.Abs(17.52028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7 - lat) + Math.Abs(16.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.2175 - lat) + Math.Abs(18.34861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28167 - lat) + Math.Abs(18.5425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26194 - lat) + Math.Abs(18.91444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.92444 - lat) + Math.Abs(17.29111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.29601 - lat) + Math.Abs(15.43865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.18472 - lat) + Math.Abs(16.59528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9 - lat) + Math.Abs(16.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35528 - lat) + Math.Abs(16.8975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14861 - lat) + Math.Abs(17.24667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.855 - lat) + Math.Abs(17.50722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.90972 - lat) + Math.Abs(15.69972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85 - lat) + Math.Abs(16.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.48333 - lat) + Math.Abs(16.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.7475 - lat) + Math.Abs(15.80583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23056 - lat) + Math.Abs(18.93194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.62333 - lat) + Math.Abs(18.19611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.32944 - lat) + Math.Abs(16.27889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.50891 - lat) + Math.Abs(16.43915 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85722 - lat) + Math.Abs(17.29944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.29806 - lat) + Math.Abs(19.095 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.80111 - lat) + Math.Abs(17.7425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.95028 - lat) + Math.Abs(18.97028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.5432 - lat) + Math.Abs(16.49314 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.11083 - lat) + Math.Abs(16.70639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.4 - lat) + Math.Abs(18.62028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24972 - lat) + Math.Abs(14.60167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.93056 - lat) + Math.Abs(16.89639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.11507 - lat) + Math.Abs(15.58458 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16222 - lat) + Math.Abs(17.93278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.24306 - lat) + Math.Abs(15.44861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16028 - lat) + Math.Abs(18.01556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.34028 - lat) + Math.Abs(17.68528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.49944 - lat) + Math.Abs(16.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.78611 - lat) + Math.Abs(17.89194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23139 - lat) + Math.Abs(16.54389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40583 - lat) + Math.Abs(16.37694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22472 - lat) + Math.Abs(18.95028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72389 - lat) + Math.Abs(17.65861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32053 - lat) + Math.Abs(14.53268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.82028 - lat) + Math.Abs(15.92361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.42778 - lat) + Math.Abs(14.91111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.12566 - lat) + Math.Abs(15.85001 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.09139 - lat) + Math.Abs(15.45389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.44944 - lat) + Math.Abs(16.50333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.68528 - lat) + Math.Abs(16.13111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.19889 - lat) + Math.Abs(18.64667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46611 - lat) + Math.Abs(16.37833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40528 - lat) + Math.Abs(18.4725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52333 - lat) + Math.Abs(17.255 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.70361 - lat) + Math.Abs(16.63944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.82944 - lat) + Math.Abs(15.33222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63333 - lat) + Math.Abs(16.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.10889 - lat) + Math.Abs(18.46444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25944 - lat) + Math.Abs(16.63889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18833 - lat) + Math.Abs(16.93583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.19167 - lat) + Math.Abs(17.90806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.73429 - lat) + Math.Abs(15.8942 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83502 - lat) + Math.Abs(16.95893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83111 - lat) + Math.Abs(16.11639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.45444 - lat) + Math.Abs(16.91139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40889 - lat) + Math.Abs(16.42167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.98944 - lat) + Math.Abs(14.90583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30389 - lat) + Math.Abs(16.47056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36056 - lat) + Math.Abs(18.54361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26833 - lat) + Math.Abs(16.61056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.75 - lat) + Math.Abs(16.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.49307 - lat) + Math.Abs(16.38937 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.02611 - lat) + Math.Abs(16.04476 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.15639 - lat) + Math.Abs(14.72111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.29722 - lat) + Math.Abs(16.85083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50833 - lat) + Math.Abs(16.30474 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35583 - lat) + Math.Abs(18.37806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61444 - lat) + Math.Abs(18.48972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52722 - lat) + Math.Abs(18.8375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23278 - lat) + Math.Abs(19.28028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57917 - lat) + Math.Abs(18.06 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.17917 - lat) + Math.Abs(18.20667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90556 - lat) + Math.Abs(17.02111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.80306 - lat) + Math.Abs(15.71806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.59639 - lat) + Math.Abs(18.50389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.06667 - lat) + Math.Abs(18.48889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22361 - lat) + Math.Abs(16.16167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.93972 - lat) + Math.Abs(15.16333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.98333 - lat) + Math.Abs(15.47806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.82412 - lat) + Math.Abs(16.25668 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14667 - lat) + Math.Abs(18.07944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.37667 - lat) + Math.Abs(17.23667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3625 - lat) + Math.Abs(14.29444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73611 - lat) + Math.Abs(16.23306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76667 - lat) + Math.Abs(15.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.6729 - lat) + Math.Abs(16.78359 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36694 - lat) + Math.Abs(14.34806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.94472 - lat) + Math.Abs(16.735 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08268 - lat) + Math.Abs(13.63457 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23111 - lat) + Math.Abs(18.74389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.52472 - lat) + Math.Abs(15.97 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.04917 - lat) + Math.Abs(17.47917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32673 - lat) + Math.Abs(14.44241 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57944 - lat) + Math.Abs(15.35139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71667 - lat) + Math.Abs(16.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78333 - lat) + Math.Abs(17.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23333 - lat) + Math.Abs(18.65306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26232 - lat) + Math.Abs(17.42346 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.49278 - lat) + Math.Abs(16.73083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18528 - lat) + Math.Abs(16.32778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13028 - lat) + Math.Abs(16.76694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51194 - lat) + Math.Abs(15.66333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.28194 - lat) + Math.Abs(15.34806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37278 - lat) + Math.Abs(14.93528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.80639 - lat) + Math.Abs(15.85472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.18389 - lat) + Math.Abs(16.70667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.08028 - lat) + Math.Abs(14.07889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73806 - lat) + Math.Abs(15.79722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.99315 - lat) + Math.Abs(15.65028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93028 - lat) + Math.Abs(16.3225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71611 - lat) + Math.Abs(18.19194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66667 - lat) + Math.Abs(16.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.79389 - lat) + Math.Abs(15.82222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.92417 - lat) + Math.Abs(18.77722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.23111 - lat) + Math.Abs(15.38083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16639 - lat) + Math.Abs(15.92361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99052 - lat) + Math.Abs(15.7701 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86389 - lat) + Math.Abs(18.95528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.07944 - lat) + Math.Abs(14.1575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.75694 - lat) + Math.Abs(14.76083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96905 - lat) + Math.Abs(15.96073 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.43306 - lat) + Math.Abs(18.41639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.01472 - lat) + Math.Abs(14.62889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86833 - lat) + Math.Abs(13.84806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.79096 - lat) + Math.Abs(16.25084 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.34778 - lat) + Math.Abs(16.73389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24361 - lat) + Math.Abs(17.35917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97056 - lat) + Math.Abs(17.12 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.84278 - lat) + Math.Abs(15.27083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21444 - lat) + Math.Abs(18.61056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.19472 - lat) + Math.Abs(18.8375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.26667 - lat) + Math.Abs(15.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.58632 - lat) + Math.Abs(15.92302 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.63083 - lat) + Math.Abs(16.17611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.82569 - lat) + Math.Abs(16.3147 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.87944 - lat) + Math.Abs(15.73806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19966 - lat) + Math.Abs(16.13194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.16667 - lat) + Math.Abs(15.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3925 - lat) + Math.Abs(16.4825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.60631 - lat) + Math.Abs(16.22912 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89083 - lat) + Math.Abs(16.75222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63722 - lat) + Math.Abs(14.57806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86667 - lat) + Math.Abs(16.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.80056 - lat) + Math.Abs(13.90861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.335 - lat) + Math.Abs(16.61556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.07667 - lat) + Math.Abs(15.20722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16417 - lat) + Math.Abs(15.75083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93583 - lat) + Math.Abs(16.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.29889 - lat) + Math.Abs(14.57361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.05096 - lat) + Math.Abs(16.02811 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.34667 - lat) + Math.Abs(15.11556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.78498 - lat) + Math.Abs(16.56069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.54889 - lat) + Math.Abs(16.59056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.37551 - lat) + Math.Abs(16.63091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 356;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.21361 - lat) + Math.Abs(15.47667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 357;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22567 - lat) + Math.Abs(13.59511 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 358;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.56972 - lat) + Math.Abs(16.625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 359;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.80917 - lat) + Math.Abs(18.65833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 360;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90076 - lat) + Math.Abs(15.87584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 361;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26667 - lat) + Math.Abs(16.57361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 362;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31722 - lat) + Math.Abs(14.26778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 363;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47 - lat) + Math.Abs(16.98083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 364;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.17806 - lat) + Math.Abs(15.37556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 365;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.01833 - lat) + Math.Abs(15.5175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 366;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48722 - lat) + Math.Abs(15.99333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 367;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.905 - lat) + Math.Abs(15.80056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 368;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.19028 - lat) + Math.Abs(18.02694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 369;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46472 - lat) + Math.Abs(16.54306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 370;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.48668 - lat) + Math.Abs(16.55013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 371;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.005 - lat) + Math.Abs(17.21167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 372;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70333 - lat) + Math.Abs(17.70278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 373;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18889 - lat) + Math.Abs(14.09806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 374;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38722 - lat) + Math.Abs(14.47944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 375;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45861 - lat) + Math.Abs(18.22278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 376;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.24333 - lat) + Math.Abs(17.07722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 377;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72917 - lat) + Math.Abs(18.27056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 378;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20972 - lat) + Math.Abs(16.29417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 379;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22389 - lat) + Math.Abs(18.01 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 380;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33139 - lat) + Math.Abs(16.54472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 381;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.05611 - lat) + Math.Abs(17.43278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 382;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28861 - lat) + Math.Abs(17.80639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 383;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.07639 - lat) + Math.Abs(15.36806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 384;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95056 - lat) + Math.Abs(17.22944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 385;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25528 - lat) + Math.Abs(18.40417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 386;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58639 - lat) + Math.Abs(15.85917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 387;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.81917 - lat) + Math.Abs(15.67278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 388;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.20611 - lat) + Math.Abs(14.04278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 389;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16806 - lat) + Math.Abs(15.84083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 390;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7 - lat) + Math.Abs(16.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 391;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28889 - lat) + Math.Abs(18.94444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 392;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.4375 - lat) + Math.Abs(16.29 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 393;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61278 - lat) + Math.Abs(18.53528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 394;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34917 - lat) + Math.Abs(16.225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 395;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.6325 - lat) + Math.Abs(18.19306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 396;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.75833 - lat) + Math.Abs(18.52806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 397;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19222 - lat) + Math.Abs(16.89167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 398;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.64944 - lat) + Math.Abs(15.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 399;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.49528 - lat) + Math.Abs(16.47611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 400;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24028 - lat) + Math.Abs(13.93667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 401;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71217 - lat) + Math.Abs(15.76366 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 402;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9 - lat) + Math.Abs(16.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 403;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.9575 - lat) + Math.Abs(15.385 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 404;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38889 - lat) + Math.Abs(16.54778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 405;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39722 - lat) + Math.Abs(16.59583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 406;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63667 - lat) + Math.Abs(16.97611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 407;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.43639 - lat) + Math.Abs(17.18889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 408;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.91222 - lat) + Math.Abs(15.50889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 409;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.445 - lat) + Math.Abs(15.0575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 410;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3725 - lat) + Math.Abs(18.84778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 411;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.60667 - lat) + Math.Abs(15.46194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 412;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.92278 - lat) + Math.Abs(17.20583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 413;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14667 - lat) + Math.Abs(18.88389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 414;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.68643 - lat) + Math.Abs(16.73329 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 415;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.86944 - lat) + Math.Abs(15.2375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 416;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.34056 - lat) + Math.Abs(18.78972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 417;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22472 - lat) + Math.Abs(15.27333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 418;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.55111 - lat) + Math.Abs(18.69389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 419;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51639 - lat) + Math.Abs(16.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 420;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14778 - lat) + Math.Abs(17.45889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 421;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99672 - lat) + Math.Abs(15.91507 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 422;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21528 - lat) + Math.Abs(18.98472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 423;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68333 - lat) + Math.Abs(16.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 424;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16611 - lat) + Math.Abs(17.76 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 425;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81618 - lat) + Math.Abs(15.80246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 426;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33167 - lat) + Math.Abs(16.50694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 427;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.07556 - lat) + Math.Abs(16.45167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 428;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.9767 - lat) + Math.Abs(17.18619 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 429;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.70194 - lat) + Math.Abs(18.00778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 430;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.54 - lat) + Math.Abs(17.88472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 431;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.01528 - lat) + Math.Abs(17.56556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 432;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38167 - lat) + Math.Abs(13.82611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 433;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.15111 - lat) + Math.Abs(18.22972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 434;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.33658 - lat) + Math.Abs(14.30782 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 435;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21134 - lat) + Math.Abs(14.55495 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 436;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.44472 - lat) + Math.Abs(16.68861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 437;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26034 - lat) + Math.Abs(17.19925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 438;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.95056 - lat) + Math.Abs(16.08222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 439;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26611 - lat) + Math.Abs(15.22861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 440;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.5 - lat) + Math.Abs(16.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 441;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72979 - lat) + Math.Abs(15.9924 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 442;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.74083 - lat) + Math.Abs(16.67972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 443;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.20056 - lat) + Math.Abs(15.68222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 444;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76667 - lat) + Math.Abs(16.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 445;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68278 - lat) + Math.Abs(16.25694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 446;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63306 - lat) + Math.Abs(16.55528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 447;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3325 - lat) + Math.Abs(18.84139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 448;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.34056 - lat) + Math.Abs(16.97694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 449;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42839 - lat) + Math.Abs(16.46215 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 450;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33083 - lat) + Math.Abs(16.4325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 451;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88333 - lat) + Math.Abs(16.88333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 452;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6525 - lat) + Math.Abs(16.53639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 453;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7 - lat) + Math.Abs(16.11667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 454;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.12806 - lat) + Math.Abs(14.78889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 455;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28722 - lat) + Math.Abs(18.59139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 456;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16194 - lat) + Math.Abs(16.33028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 457;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24 - lat) + Math.Abs(18.89611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 458;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.07806 - lat) + Math.Abs(16.95389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 459;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.315 - lat) + Math.Abs(13.55806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 460;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.18389 - lat) + Math.Abs(15.55417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 461;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17252 - lat) + Math.Abs(15.9809 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 462;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37194 - lat) + Math.Abs(16.92083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 463;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.79694 - lat) + Math.Abs(16.95361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 464;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.55778 - lat) + Math.Abs(14.88667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 465;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.45167 - lat) + Math.Abs(16.57278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 466;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88484 - lat) + Math.Abs(15.86228 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 467;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.19889 - lat) + Math.Abs(17.63917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 468;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.255 - lat) + Math.Abs(17.38306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 469;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66472 - lat) + Math.Abs(17.76694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 470;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.15806 - lat) + Math.Abs(14.53861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 471;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14028 - lat) + Math.Abs(19.03556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 472;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.33111 - lat) + Math.Abs(16.57861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 473;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.68056 - lat) + Math.Abs(16.52111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 474;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27944 - lat) + Math.Abs(18.99667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 475;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14 - lat) + Math.Abs(14.11194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 476;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28778 - lat) + Math.Abs(16.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 477;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37583 - lat) + Math.Abs(16.3875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 478;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48861 - lat) + Math.Abs(18.08778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 479;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83278 - lat) + Math.Abs(16.78611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 480;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66306 - lat) + Math.Abs(18.48417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 481;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.50944 - lat) + Math.Abs(16.44111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 482;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.14722 - lat) + Math.Abs(15.32417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 483;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.82043 - lat) + Math.Abs(15.58988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 484;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.77111 - lat) + Math.Abs(14.7625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 485;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32639 - lat) + Math.Abs(18.59278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 486;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31556 - lat) + Math.Abs(14.85528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 487;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.53333 - lat) + Math.Abs(16.52194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 488;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66667 - lat) + Math.Abs(16.09556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 489;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15 - lat) + Math.Abs(16.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 490;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.33667 - lat) + Math.Abs(13.82861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 491;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78608 - lat) + Math.Abs(17.98339 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 492;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23778 - lat) + Math.Abs(14.25222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 493;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76836 - lat) + Math.Abs(15.75774 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 494;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.10917 - lat) + Math.Abs(17.03167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 495;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.67556 - lat) + Math.Abs(18.09028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 496;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.62306 - lat) + Math.Abs(18.20722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 497;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26972 - lat) + Math.Abs(18.85111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 498;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66611 - lat) + Math.Abs(17.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 499;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.32667 - lat) + Math.Abs(16.45083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 500;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61861 - lat) + Math.Abs(17.80389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 501;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40861 - lat) + Math.Abs(16.44806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 502;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13306 - lat) + Math.Abs(15.97222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 503;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31722 - lat) + Math.Abs(17.87278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 504;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.75 - lat) + Math.Abs(16.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 505;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.05417 - lat) + Math.Abs(17.64833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 506;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.8225 - lat) + Math.Abs(13.935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 507;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61889 - lat) + Math.Abs(18.72056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 508;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36167 - lat) + Math.Abs(14.325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 509;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28889 - lat) + Math.Abs(16.18306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 510;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51083 - lat) + Math.Abs(18.46917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 511;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.49222 - lat) + Math.Abs(18.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 512;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26583 - lat) + Math.Abs(16.54 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 513;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37389 - lat) + Math.Abs(18.70583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 514;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.49389 - lat) + Math.Abs(18.12556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 515;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66694 - lat) + Math.Abs(18.29222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 516;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.365 - lat) + Math.Abs(14.39389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 517;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.34 - lat) + Math.Abs(18.89944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 518;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.51472 - lat) + Math.Abs(16.10639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 519;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.91097 - lat) + Math.Abs(15.7277 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 520;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00611 - lat) + Math.Abs(16.11111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 521;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.39611 - lat) + Math.Abs(14.38944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 522;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.95528 - lat) + Math.Abs(13.95389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 523;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.32917 - lat) + Math.Abs(16.14806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 524;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.12417 - lat) + Math.Abs(14.52828 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 525;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.53056 - lat) + Math.Abs(14.46861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 526;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28306 - lat) + Math.Abs(16.73917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 527;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37616 - lat) + Math.Abs(16.52893 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 528;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78333 - lat) + Math.Abs(15.71667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 529;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47373 - lat) + Math.Abs(16.24414 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 530;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09609 - lat) + Math.Abs(15.78516 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 531;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.29694 - lat) + Math.Abs(17.01778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 532;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33333 - lat) + Math.Abs(16.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 533;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42417 - lat) + Math.Abs(16.43361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 534;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39361 - lat) + Math.Abs(16.32833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 535;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09472 - lat) + Math.Abs(16.03528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 536;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16806 - lat) + Math.Abs(17.70694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 537;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.79639 - lat) + Math.Abs(16.34639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 538;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.92278 - lat) + Math.Abs(17.16722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 539;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.10306 - lat) + Math.Abs(15.15889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 540;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70444 - lat) + Math.Abs(15.99 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 541;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.8725 - lat) + Math.Abs(17.41944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 542;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95795 - lat) + Math.Abs(15.81954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 543;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66222 - lat) + Math.Abs(18.77583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 544;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25194 - lat) + Math.Abs(16.61472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 545;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76111 - lat) + Math.Abs(15.87028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 546;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.17583 - lat) + Math.Abs(13.74194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 547;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.48761 - lat) + Math.Abs(16.98632 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 548;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.29194 - lat) + Math.Abs(14.27417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 549;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.39139 - lat) + Math.Abs(15.68556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 550;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22639 - lat) + Math.Abs(19.17111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 551;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.43333 - lat) + Math.Abs(16.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 552;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.8325 - lat) + Math.Abs(14.73028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 553;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.855 - lat) + Math.Abs(16.33 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 554;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.46345 - lat) + Math.Abs(17.09155 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 555;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35889 - lat) + Math.Abs(14.74861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 556;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.91528 - lat) + Math.Abs(13.90556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 557;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15278 - lat) + Math.Abs(16.06778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 558;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.2175 - lat) + Math.Abs(17.38278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 559;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16667 - lat) + Math.Abs(16.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 560;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.82833 - lat) + Math.Abs(13.95694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 561;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.96861 - lat) + Math.Abs(15.77417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 562;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41139 - lat) + Math.Abs(17.15222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 563;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58368 - lat) + Math.Abs(16.37617 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 564;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.80472 - lat) + Math.Abs(15.32472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 565;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.60389 - lat) + Math.Abs(15.42472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 566;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27904 - lat) + Math.Abs(14.71906 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 567;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31556 - lat) + Math.Abs(18.18361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 568;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21056 - lat) + Math.Abs(16.03556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 569;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58556 - lat) + Math.Abs(16.21139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 570;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.2975 - lat) + Math.Abs(16.85667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 571;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.64191 - lat) + Math.Abs(16.34954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 572;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96667 - lat) + Math.Abs(16.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 573;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.76757 - lat) + Math.Abs(16.89708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 574;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.85167 - lat) + Math.Abs(17.03 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 575;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.415 - lat) + Math.Abs(18.69611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 576;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52806 - lat) + Math.Abs(15.85911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 577;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40722 - lat) + Math.Abs(14.11639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 578;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.62556 - lat) + Math.Abs(18.44861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 579;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.095 - lat) + Math.Abs(14.11972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 580;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.42611 - lat) + Math.Abs(17.8825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 581;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51667 - lat) + Math.Abs(16.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 582;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.475 - lat) + Math.Abs(16.78194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 583;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.82528 - lat) + Math.Abs(15.14083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 584;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.34778 - lat) + Math.Abs(18.42889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 585;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33028 - lat) + Math.Abs(16.40167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 586;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.92918 - lat) + Math.Abs(15.80589 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 587;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65861 - lat) + Math.Abs(15.78694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 588;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.62028 - lat) + Math.Abs(18.19139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 589;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.0775 - lat) + Math.Abs(15.67556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 590;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.03111 - lat) + Math.Abs(17.605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 591;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.32556 - lat) + Math.Abs(14.54 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 592;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.43333 - lat) + Math.Abs(16.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 593;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.67694 - lat) + Math.Abs(16.145 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 594;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28944 - lat) + Math.Abs(16.37222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 595;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.18333 - lat) + Math.Abs(15.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 596;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0775 - lat) + Math.Abs(18.48278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 597;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.17333 - lat) + Math.Abs(14.13861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 598;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.33333 - lat) + Math.Abs(15.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 599;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.02744 - lat) + Math.Abs(14.57542 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 600;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.02111 - lat) + Math.Abs(15.16528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 601;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.02194 - lat) + Math.Abs(16.5425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 602;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.665 - lat) + Math.Abs(16.52333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 603;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.44417 - lat) + Math.Abs(16.4525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 604;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58333 - lat) + Math.Abs(16.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 605;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30972 - lat) + Math.Abs(14.55556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 606;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65583 - lat) + Math.Abs(15.51778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 607;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09333 - lat) + Math.Abs(15.84333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 608;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16083 - lat) + Math.Abs(15.87889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 609;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27395 - lat) + Math.Abs(14.5683 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 610;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.99106 - lat) + Math.Abs(15.7247 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 611;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.17056 - lat) + Math.Abs(15.19556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 612;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68333 - lat) + Math.Abs(17.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 613;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.92889 - lat) + Math.Abs(17.11722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 614;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71917 - lat) + Math.Abs(18.67611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 615;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26667 - lat) + Math.Abs(17.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 616;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.355 - lat) + Math.Abs(16.81806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 617;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.63083 - lat) + Math.Abs(16.695 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 618;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30111 - lat) + Math.Abs(14.50556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 619;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.44083 - lat) + Math.Abs(16.83311 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 620;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.255 - lat) + Math.Abs(16.53194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 621;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23167 - lat) + Math.Abs(16.53917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 622;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.54528 - lat) + Math.Abs(18.28583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 623;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38444 - lat) + Math.Abs(18.56556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 624;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.96038 - lat) + Math.Abs(17.13525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 625;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16278 - lat) + Math.Abs(16.8275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 626;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.60194 - lat) + Math.Abs(18.78639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 627;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63611 - lat) + Math.Abs(17.16639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 628;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14972 - lat) + Math.Abs(18.94917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 629;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.04306 - lat) + Math.Abs(16.09306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 630;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.04083 - lat) + Math.Abs(17.53694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 631;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.49417 - lat) + Math.Abs(14.96139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 632;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73333 - lat) + Math.Abs(16.1 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 633;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.05139 - lat) + Math.Abs(16.21083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 634;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.04063 - lat) + Math.Abs(16.19662 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 635;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.84611 - lat) + Math.Abs(18.64278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 636;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.75028 - lat) + Math.Abs(18.73306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 637;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.98111 - lat) + Math.Abs(17.15583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 638;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.74056 - lat) + Math.Abs(16.42417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 639;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21972 - lat) + Math.Abs(18.15028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 640;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.91667 - lat) + Math.Abs(16.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 641;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88278 - lat) + Math.Abs(15.69242 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 642;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16861 - lat) + Math.Abs(16.35944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 643;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.55944 - lat) + Math.Abs(16.51944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 644;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.69028 - lat) + Math.Abs(15.74111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 645;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.27028 - lat) + Math.Abs(16.07 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 646;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.04982 - lat) + Math.Abs(15.74418 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 647;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.44694 - lat) + Math.Abs(14.37694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 648;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.09861 - lat) + Math.Abs(18.13222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 649;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.98278 - lat) + Math.Abs(15.965 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 650;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.97725 - lat) + Math.Abs(16.3571 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 651;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35139 - lat) + Math.Abs(18.55861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 652;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7701 - lat) + Math.Abs(15.80864 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 653;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25667 - lat) + Math.Abs(16.43528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 654;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.46417 - lat) + Math.Abs(16.89694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 655;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.55028 - lat) + Math.Abs(16.42639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 656;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.55 - lat) + Math.Abs(16.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 657;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.55 - lat) + Math.Abs(16.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 658;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.55 - lat) + Math.Abs(16.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 659;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.55528 - lat) + Math.Abs(16.3675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 660;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.55 - lat) + Math.Abs(16.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 661;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30333 - lat) + Math.Abs(13.68528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 662;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.55 - lat) + Math.Abs(16.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 663;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37528 - lat) + Math.Abs(14.34861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 664;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.91134 - lat) + Math.Abs(16.12436 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 665;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30083 - lat) + Math.Abs(13.82306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 666;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29194 - lat) + Math.Abs(16.62944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 667;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.5275 - lat) + Math.Abs(15.07389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 668;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76056 - lat) + Math.Abs(18.68444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 669;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.73472 - lat) + Math.Abs(16.63694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 670;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.43472 - lat) + Math.Abs(17.72611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 671;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57528 - lat) + Math.Abs(16.89333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 672;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.98833 - lat) + Math.Abs(16.85139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 673;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.10806 - lat) + Math.Abs(17.88611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 674;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.12194 - lat) + Math.Abs(13.83917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 675;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63528 - lat) + Math.Abs(15.39583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 676;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.12833 - lat) + Math.Abs(16.4625 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 677;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.02944 - lat) + Math.Abs(17.11556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 678;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.06278 - lat) + Math.Abs(15.20556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 679;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3775 - lat) + Math.Abs(14.32194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 680;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38139 - lat) + Math.Abs(14.31722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 681;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.42361 - lat) + Math.Abs(18.41833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 682;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.58278 - lat) + Math.Abs(18.58139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 683;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.185 - lat) + Math.Abs(15.28667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 684;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.7876 - lat) + Math.Abs(15.64108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 685;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78333 - lat) + Math.Abs(15.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 686;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.23 - lat) + Math.Abs(15.5775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 687;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.46158 - lat) + Math.Abs(16.60197 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 688;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03972 - lat) + Math.Abs(16.18722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 689;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23889 - lat) + Math.Abs(16.10861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 690;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.16139 - lat) + Math.Abs(16.69306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 691;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52889 - lat) + Math.Abs(18.15611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 692;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38611 - lat) + Math.Abs(14.45111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 693;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86019 - lat) + Math.Abs(15.76444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 694;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66833 - lat) + Math.Abs(15.64861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 695;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27167 - lat) + Math.Abs(16.91167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 696;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.11583 - lat) + Math.Abs(18.42028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 697;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31806 - lat) + Math.Abs(18.72917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 698;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.92528 - lat) + Math.Abs(17.42833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 699;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26083 - lat) + Math.Abs(16.475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 700;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28083 - lat) + Math.Abs(16.31972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 701;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35806 - lat) + Math.Abs(17.76389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 702;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93611 - lat) + Math.Abs(15.85559 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 703;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7 - lat) + Math.Abs(16.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 704;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.69917 - lat) + Math.Abs(18.57694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 705;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23111 - lat) + Math.Abs(14.61833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 706;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.87583 - lat) + Math.Abs(15.85361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 707;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.77889 - lat) + Math.Abs(16.81194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 708;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36833 - lat) + Math.Abs(16.47667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 709;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36944 - lat) + Math.Abs(18.41361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 710;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28861 - lat) + Math.Abs(18.68389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 711;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70833 - lat) + Math.Abs(16.39694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 712;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.84694 - lat) + Math.Abs(15.83139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 713;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.22306 - lat) + Math.Abs(16.12 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 714;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.44667 - lat) + Math.Abs(17.21667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 715;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45167 - lat) + Math.Abs(16.8725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 716;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22222 - lat) + Math.Abs(19.37694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 717;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18139 - lat) + Math.Abs(19.09583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 718;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96183 - lat) + Math.Abs(15.87739 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 719;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.1725 - lat) + Math.Abs(16.44278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 720;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47417 - lat) + Math.Abs(16.81306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 721;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00667 - lat) + Math.Abs(16.08917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 722;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21139 - lat) + Math.Abs(15.69083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 723;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.10722 - lat) + Math.Abs(16.27667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 724;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29861 - lat) + Math.Abs(16.57444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 725;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.76333 - lat) + Math.Abs(16.615 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 726;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.29667 - lat) + Math.Abs(15.18139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 727;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.2825 - lat) + Math.Abs(14.59917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 728;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24917 - lat) + Math.Abs(16.58444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 729;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.1125 - lat) + Math.Abs(16.2275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 730;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7 - lat) + Math.Abs(15.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 731;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39528 - lat) + Math.Abs(16.64389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 732;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15694 - lat) + Math.Abs(16.96278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 733;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.52083 - lat) + Math.Abs(16.40056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 734;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.17972 - lat) + Math.Abs(16.86833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 735;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65861 - lat) + Math.Abs(17.01361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 736;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.59 - lat) + Math.Abs(18.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 737;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.91 - lat) + Math.Abs(16.58194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 738;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.88 - lat) + Math.Abs(18.85333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 739;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.15833 - lat) + Math.Abs(18.49139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 740;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88028 - lat) + Math.Abs(16.78083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 741;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70214 - lat) + Math.Abs(17.17268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 742;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37889 - lat) + Math.Abs(13.72389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 743;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.17944 - lat) + Math.Abs(17.9575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 744;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.63333 - lat) + Math.Abs(15.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 745;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14806 - lat) + Math.Abs(18.70667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 746;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7 - lat) + Math.Abs(16.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 747;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.91111 - lat) + Math.Abs(16.48278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 748;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31306 - lat) + Math.Abs(17.81528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 749;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.10583 - lat) + Math.Abs(17.34167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 750;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.21889 - lat) + Math.Abs(14.01056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 751;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83333 - lat) + Math.Abs(16.31667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 752;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.29916 - lat) + Math.Abs(15.84752 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 753;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.69722 - lat) + Math.Abs(18.74 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 754;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.64694 - lat) + Math.Abs(16.76139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 755;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.54611 - lat) + Math.Abs(15.37472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 756;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.49473 - lat) + Math.Abs(16.26531 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 757;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42864 - lat) + Math.Abs(16.33328 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 758;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88409 - lat) + Math.Abs(15.71268 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 759;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.46667 - lat) + Math.Abs(16.47056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 760;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25051 - lat) + Math.Abs(16.37555 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 761;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.13598 - lat) + Math.Abs(15.63423 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 762;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37806 - lat) + Math.Abs(16.34861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 763;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.69299 - lat) + Math.Abs(15.69157 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 764;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.25944 - lat) + Math.Abs(17.23611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 765;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35917 - lat) + Math.Abs(16.15444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 766;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.39314 - lat) + Math.Abs(17.17953 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 767;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93333 - lat) + Math.Abs(16.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 768;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31167 - lat) + Math.Abs(16.16806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 769;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41222 - lat) + Math.Abs(16.42194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 770;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20639 - lat) + Math.Abs(15.9125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 771;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.15528 - lat) + Math.Abs(18.06556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 772;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3154 - lat) + Math.Abs(16.07635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 773;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97519 - lat) + Math.Abs(16.01931 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 774;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.92859 - lat) + Math.Abs(15.77165 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 775;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71667 - lat) + Math.Abs(16 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 776;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.59944 - lat) + Math.Abs(16.69944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 777;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81217 - lat) + Math.Abs(16.32156 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 778;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51278 - lat) + Math.Abs(16.69583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 779;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.91667 - lat) + Math.Abs(15.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 780;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.39889 - lat) + Math.Abs(18.37222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 781;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38417 - lat) + Math.Abs(16.68083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 782;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.14167 - lat) + Math.Abs(14.01528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 783;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19583 - lat) + Math.Abs(17.05806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 784;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28778 - lat) + Math.Abs(16.30306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 785;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.11556 - lat) + Math.Abs(16.87444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 786;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.33806 - lat) + Math.Abs(16.08806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 787;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51472 - lat) + Math.Abs(14.64222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 788;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.34778 - lat) + Math.Abs(15.38306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 789;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.46667 - lat) + Math.Abs(16.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 790;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.70611 - lat) + Math.Abs(18.32556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 791;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.33472 - lat) + Math.Abs(18.31639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 792;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57444 - lat) + Math.Abs(16.94139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 793;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.42694 - lat) + Math.Abs(16.5575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 794;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18278 - lat) + Math.Abs(18.18306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 795;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.07139 - lat) + Math.Abs(15.39333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 796;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.93167 - lat) + Math.Abs(13.86861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 797;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73333 - lat) + Math.Abs(15.75 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 798;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.715 - lat) + Math.Abs(16.72694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 799;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35306 - lat) + Math.Abs(18.73611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 800;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30528 - lat) + Math.Abs(14.71556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 801;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.17472 - lat) + Math.Abs(13.605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 802;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.96472 - lat) + Math.Abs(15.43 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 803;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52889 - lat) + Math.Abs(17.97583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 804;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.05 - lat) + Math.Abs(17.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 805;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.92742 - lat) + Math.Abs(13.80349 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 806;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.09944 - lat) + Math.Abs(15.94528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 807;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45194 - lat) + Math.Abs(18.65917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 808;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52639 - lat) + Math.Abs(19.06028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 809;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35667 - lat) + Math.Abs(17.73056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 810;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.07306 - lat) + Math.Abs(16.37083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 811;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.19639 - lat) + Math.Abs(15.84083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 812;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.04111 - lat) + Math.Abs(17.06972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 813;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.54333 - lat) + Math.Abs(18.04583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 814;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.39 - lat) + Math.Abs(16.37361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 815;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86361 - lat) + Math.Abs(17.45056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 816;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.80611 - lat) + Math.Abs(16.24444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 817;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.58056 - lat) + Math.Abs(16.60278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 818;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.44611 - lat) + Math.Abs(16.63972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 819;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.42861 - lat) + Math.Abs(15.48833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 820;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.44278 - lat) + Math.Abs(16.66833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 821;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.64125 - lat) + Math.Abs(18.10909 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 822;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.05203 - lat) + Math.Abs(15.80014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 823;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.85306 - lat) + Math.Abs(15.93889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 824;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.95 - lat) + Math.Abs(15.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 825;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83777 - lat) + Math.Abs(16.53751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 826;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88944 - lat) + Math.Abs(18.69667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 827;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.19111 - lat) + Math.Abs(16.80028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 828;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35028 - lat) + Math.Abs(16.22472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 829;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20694 - lat) + Math.Abs(16.91694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 830;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.8625 - lat) + Math.Abs(16.15556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 831;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09139 - lat) + Math.Abs(17.15167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 832;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.92056 - lat) + Math.Abs(18.91222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 833;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35 - lat) + Math.Abs(14.43028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 834;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38111 - lat) + Math.Abs(18.28194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 835;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.39083 - lat) + Math.Abs(14.47028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 836;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.84222 - lat) + Math.Abs(18.78861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 837;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.88944 - lat) + Math.Abs(15.54083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 838;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.6 - lat) + Math.Abs(15.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 839;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24417 - lat) + Math.Abs(17.28861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 840;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.10667 - lat) + Math.Abs(15.38056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 841;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.32917 - lat) + Math.Abs(16.78667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 842;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.51667 - lat) + Math.Abs(16.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 843;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.46972 - lat) + Math.Abs(17.15639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 844;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76083 - lat) + Math.Abs(18.16722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 845;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.33528 - lat) + Math.Abs(16.71444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 846;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.55306 - lat) + Math.Abs(15.96194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 847;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.88333 - lat) + Math.Abs(15.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 848;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.28028 - lat) + Math.Abs(16.39361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 849;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36611 - lat) + Math.Abs(16.65278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 850;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25944 - lat) + Math.Abs(16.38444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 851;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41222 - lat) + Math.Abs(16.62528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 852;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68222 - lat) + Math.Abs(15.70889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 853;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18833 - lat) + Math.Abs(18.29972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 854;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46 - lat) + Math.Abs(16.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 855;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.15333 - lat) + Math.Abs(16.28472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 856;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3 - lat) + Math.Abs(16.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 857;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9096 - lat) + Math.Abs(16.23024 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 858;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.66667 - lat) + Math.Abs(15.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 859;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16583 - lat) + Math.Abs(18.10667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 860;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.30083 - lat) + Math.Abs(16.105 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 861;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.3 - lat) + Math.Abs(16.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 862;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.98333 - lat) + Math.Abs(15.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 863;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.91667 - lat) + Math.Abs(15.77778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 864;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09136 - lat) + Math.Abs(15.8822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 865;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.49472 - lat) + Math.Abs(18.02417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 866;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.71194 - lat) + Math.Abs(16.02694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 867;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.55056 - lat) + Math.Abs(15.81222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 868;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.495 - lat) + Math.Abs(16.67944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 869;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.31472 - lat) + Math.Abs(16.81194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 870;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.36889 - lat) + Math.Abs(16.93417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 871;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90778 - lat) + Math.Abs(15.85444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 872;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.80834 - lat) + Math.Abs(15.75306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 873;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.4325 - lat) + Math.Abs(16.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 874;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63167 - lat) + Math.Abs(15.64028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 875;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.5675 - lat) + Math.Abs(17.22528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 876;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.12667 - lat) + Math.Abs(14.60333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 877;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57056 - lat) + Math.Abs(17.08667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 878;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14861 - lat) + Math.Abs(15.66861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 879;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40083 - lat) + Math.Abs(14.79972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 880;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24861 - lat) + Math.Abs(16.86667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 881;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.44861 - lat) + Math.Abs(16.58472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 882;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.05111 - lat) + Math.Abs(15.36472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 883;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.69528 - lat) + Math.Abs(16.48194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 884;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.11528 - lat) + Math.Abs(17.51639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 885;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.59056 - lat) + Math.Abs(17.225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 886;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.62806 - lat) + Math.Abs(18.69972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 887;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.48438 - lat) + Math.Abs(18.9861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 888;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30833 - lat) + Math.Abs(18.41056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 889;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.00245 - lat) + Math.Abs(16.66489 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 890;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.65139 - lat) + Math.Abs(15.65222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 891;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.98333 - lat) + Math.Abs(16.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 892;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.11417 - lat) + Math.Abs(15.29111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 893;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7075 - lat) + Math.Abs(18.295 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 894;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.26667 - lat) + Math.Abs(16.35 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 895;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.69611 - lat) + Math.Abs(17.93722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 896;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.17722 - lat) + Math.Abs(14.69278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 897;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.57556 - lat) + Math.Abs(18.4125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 898;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.96092 - lat) + Math.Abs(14.41246 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 899;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.82778 - lat) + Math.Abs(15.30111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 900;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.95 - lat) + Math.Abs(16.4 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 901;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.50333 - lat) + Math.Abs(16.94778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 902;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.93167 - lat) + Math.Abs(16.66083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 903;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.34444 - lat) + Math.Abs(16.64944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 904;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.62889 - lat) + Math.Abs(18.17111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 905;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.15972 - lat) + Math.Abs(15.73944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 906;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.37167 - lat) + Math.Abs(16.12528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 907;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27806 - lat) + Math.Abs(14.01222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 908;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.34361 - lat) + Math.Abs(14.50222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 909;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.28861 - lat) + Math.Abs(17.38194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 910;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18194 - lat) + Math.Abs(18.68944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 911;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.31139 - lat) + Math.Abs(18.85611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 912;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.61917 - lat) + Math.Abs(17.68583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 913;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52361 - lat) + Math.Abs(18.56333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 914;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68639 - lat) + Math.Abs(18.6675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 915;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.36472 - lat) + Math.Abs(16.62056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 916;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.74818 - lat) + Math.Abs(16.6139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 917;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.58111 - lat) + Math.Abs(18.21806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 918;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35194 - lat) + Math.Abs(14.48389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 919;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.93833 - lat) + Math.Abs(16.93472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 920;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.38444 - lat) + Math.Abs(16.43389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 921;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.195 - lat) + Math.Abs(18.36472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 922;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.34972 - lat) + Math.Abs(17.98972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 923;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.74417 - lat) + Math.Abs(17.85472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 924;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.60389 - lat) + Math.Abs(17.87028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 925;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.75389 - lat) + Math.Abs(17.57806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 926;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40944 - lat) + Math.Abs(13.96667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 927;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63444 - lat) + Math.Abs(16.11972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 928;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89694 - lat) + Math.Abs(17.35556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 929;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.7 - lat) + Math.Abs(16.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 930;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18528 - lat) + Math.Abs(18.07 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 931;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.03333 - lat) + Math.Abs(15.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 932;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.41 - lat) + Math.Abs(13.66194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 933;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27111 - lat) + Math.Abs(18.44861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 934;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.12894 - lat) + Math.Abs(16.20595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 935;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.465 - lat) + Math.Abs(18.32278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 936;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47472 - lat) + Math.Abs(16.43667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 937;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.98333 - lat) + Math.Abs(17.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 938;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38139 - lat) + Math.Abs(13.62944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 939;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36278 - lat) + Math.Abs(18.91111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 940;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18111 - lat) + Math.Abs(17.97861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 941;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16778 - lat) + Math.Abs(17.80361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 942;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.46528 - lat) + Math.Abs(14.97444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 943;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.54417 - lat) + Math.Abs(18.44944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 944;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3075 - lat) + Math.Abs(16.95167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 945;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.68 - lat) + Math.Abs(16.64972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 946;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.16333 - lat) + Math.Abs(15.305 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 947;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.0025 - lat) + Math.Abs(15.13389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 948;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16111 - lat) + Math.Abs(14.76472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 949;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72919 - lat) + Math.Abs(15.91069 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 950;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.8675 - lat) + Math.Abs(16.84083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 951;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.53667 - lat) + Math.Abs(18.20556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 952;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.07111 - lat) + Math.Abs(16.27111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 953;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.41861 - lat) + Math.Abs(16.38889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 954;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.33056 - lat) + Math.Abs(17.59694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 955;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.35639 - lat) + Math.Abs(16.95861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 956;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.13861 - lat) + Math.Abs(16.90583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 957;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.84013 - lat) + Math.Abs(15.68792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 958;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86666 - lat) + Math.Abs(15.77102 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 959;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.83333 - lat) + Math.Abs(16.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 960;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.86667 - lat) + Math.Abs(16.41667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 961;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.62139 - lat) + Math.Abs(15.82722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 962;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.79611 - lat) + Math.Abs(18.61 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 963;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05028 - lat) + Math.Abs(18.75556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 964;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40139 - lat) + Math.Abs(15.28833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 965;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37639 - lat) + Math.Abs(18.96694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 966;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78611 - lat) + Math.Abs(17.46167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 967;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72111 - lat) + Math.Abs(18.51694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 968;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.26194 - lat) + Math.Abs(16.655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 969;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.34083 - lat) + Math.Abs(18.93083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 970;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.19833 - lat) + Math.Abs(17.44389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 971;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.42111 - lat) + Math.Abs(18.85389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 972;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.94083 - lat) + Math.Abs(16.79167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 973;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.89861 - lat) + Math.Abs(16.84889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 974;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.59278 - lat) + Math.Abs(18.45889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 975;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.69167 - lat) + Math.Abs(18.39861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 976;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.01139 - lat) + Math.Abs(16.23722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 977;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.96194 - lat) + Math.Abs(16.2425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 978;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.94333 - lat) + Math.Abs(15.45194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 979;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.60694 - lat) + Math.Abs(18.74389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 980;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.78869 - lat) + Math.Abs(15.87473 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 981;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51722 - lat) + Math.Abs(18.87083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 982;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.16694 - lat) + Math.Abs(18.19139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 983;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.07288 - lat) + Math.Abs(15.28396 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 984;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25 - lat) + Math.Abs(16.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 985;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73833 - lat) + Math.Abs(16.83028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 986;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.15139 - lat) + Math.Abs(18.43028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 987;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.03444 - lat) + Math.Abs(15.61278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 988;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.63861 - lat) + Math.Abs(18.17667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 989;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.56444 - lat) + Math.Abs(18.01389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 990;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68028 - lat) + Math.Abs(18.40583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 991;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.77 - lat) + Math.Abs(18.60361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 992;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.40417 - lat) + Math.Abs(16.51833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 993;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.21898 - lat) + Math.Abs(16.30783 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 994;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.45528 - lat) + Math.Abs(18.4775 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 995;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23056 - lat) + Math.Abs(15.98278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 996;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.03333 - lat) + Math.Abs(16.24278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 997;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.24028 - lat) + Math.Abs(16.07194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 998;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.04111 - lat) + Math.Abs(15.99639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 999;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.09833 - lat) + Math.Abs(17.83417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1000;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18944 - lat) + Math.Abs(17.66639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1001;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.84611 - lat) + Math.Abs(18.85 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1002;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.35694 - lat) + Math.Abs(16.95028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1003;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.97028 - lat) + Math.Abs(14.75333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1004;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.29806 - lat) + Math.Abs(16.44111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1005;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38333 - lat) + Math.Abs(15.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1006;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.06444 - lat) + Math.Abs(14.01361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1007;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.75556 - lat) + Math.Abs(18.47028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1008;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.1975 - lat) + Math.Abs(19.26 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1009;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.44167 - lat) + Math.Abs(16.905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1010;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.825 - lat) + Math.Abs(13.86611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1011;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.75 - lat) + Math.Abs(14.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1012;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.04056 - lat) + Math.Abs(13.78361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1013;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.74111 - lat) + Math.Abs(17.68694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1014;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.30861 - lat) + Math.Abs(14.53028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1015;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.51167 - lat) + Math.Abs(17.19278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1016;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.73333 - lat) + Math.Abs(17.56194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1017;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.11722 - lat) + Math.Abs(18.53694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1018;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.49083 - lat) + Math.Abs(18.675 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1019;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.38167 - lat) + Math.Abs(18.75111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1020;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22472 - lat) + Math.Abs(18.73806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1021;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.9879 - lat) + Math.Abs(15.94331 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1022;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52889 - lat) + Math.Abs(18.95056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1023;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.24778 - lat) + Math.Abs(17.465 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1024;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.90485 - lat) + Math.Abs(16.16376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1025;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.57667 - lat) + Math.Abs(18.23917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1026;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76667 - lat) + Math.Abs(15.78333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1027;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78333 - lat) + Math.Abs(15.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1028;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.79167 - lat) + Math.Abs(15.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1029;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.80846 - lat) + Math.Abs(15.88245 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1030;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.80833 - lat) + Math.Abs(15.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1031;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.78333 - lat) + Math.Abs(15.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1032;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.54419 - lat) + Math.Abs(16.27968 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1033;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.68 - lat) + Math.Abs(15.91972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1034;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.09694 - lat) + Math.Abs(15.635 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1035;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.34528 - lat) + Math.Abs(14.48833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1036;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.15861 - lat) + Math.Abs(17.45083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1037;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.13889 - lat) + Math.Abs(17.42556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1038;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.44613 - lat) + Math.Abs(17.24064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1039;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.47833 - lat) + Math.Abs(18.15556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1040;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.62278 - lat) + Math.Abs(16.74417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1041;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.23694 - lat) + Math.Abs(17.49583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1042;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50889 - lat) + Math.Abs(15.41333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1043;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.26639 - lat) + Math.Abs(16.48333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1044;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.5125 - lat) + Math.Abs(16.27722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1045;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.39667 - lat) + Math.Abs(16.88972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1046;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.35056 - lat) + Math.Abs(16.67667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1047;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.23833 - lat) + Math.Abs(16.0575 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1048;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.14861 - lat) + Math.Abs(16.05889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1049;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.03472 - lat) + Math.Abs(15.24556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1050;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.08111 - lat) + Math.Abs(15.1875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1051;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.16778 - lat) + Math.Abs(16.30583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1052;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.20278 - lat) + Math.Abs(16.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1053;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.18389 - lat) + Math.Abs(15.48778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1054;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.87944 - lat) + Math.Abs(16.64083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1055;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.24139 - lat) + Math.Abs(15.17833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1056;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.43 - lat) + Math.Abs(15.06222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1057;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.63917 - lat) + Math.Abs(15.17917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1058;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97639 - lat) + Math.Abs(15.87306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1059;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.775 - lat) + Math.Abs(14.71861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1060;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18417 - lat) + Math.Abs(18.09056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1061;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.3325 - lat) + Math.Abs(17.71472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1062;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.33 - lat) + Math.Abs(17.72806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1063;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.18278 - lat) + Math.Abs(17.93083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1064;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.40528 - lat) + Math.Abs(18.97583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1065;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.84861 - lat) + Math.Abs(17.83639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1066;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.62667 - lat) + Math.Abs(18.19833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1067;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.54972 - lat) + Math.Abs(18.28472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1068;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.83306 - lat) + Math.Abs(17.75111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1069;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.04778 - lat) + Math.Abs(16.22389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1070;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.64306 - lat) + Math.Abs(16.57028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1071;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.71361 - lat) + Math.Abs(16.64111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1072;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.51417 - lat) + Math.Abs(16.51472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1073;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.5325 - lat) + Math.Abs(16.53083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1074;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.34611 - lat) + Math.Abs(17.10583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1075;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.41083 - lat) + Math.Abs(17.20556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1076;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.61528 - lat) + Math.Abs(16.69361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1077;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.05361 - lat) + Math.Abs(16.36861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1078;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.49278 - lat) + Math.Abs(17.20111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1079;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.14083 - lat) + Math.Abs(17.27694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1080;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.42986 - lat) + Math.Abs(17.16292 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1081;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.99917 - lat) + Math.Abs(17.52417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1082;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.02194 - lat) + Math.Abs(17.58389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1083;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.22472 - lat) + Math.Abs(18.16556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1084;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.52056 - lat) + Math.Abs(18.67194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1085;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.5286 - lat) + Math.Abs(18.60106 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1086;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.67972 - lat) + Math.Abs(16.35361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1087;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.50222 - lat) + Math.Abs(16.4175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1088;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.27194 - lat) + Math.Abs(13.59722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1089;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.49167 - lat) + Math.Abs(15.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1090;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.81313 - lat) + Math.Abs(15.97753 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1091;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.97585 - lat) + Math.Abs(15.93238 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1092;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.37572 - lat) + Math.Abs(14.384 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1093;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.72626 - lat) + Math.Abs(16.12544 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1094;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76094 - lat) + Math.Abs(16.08081 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1095;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.68313 - lat) + Math.Abs(16.18003 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1096;
                                        }
                                    
                                        if ((tmp = (Math.Abs(43.41408 - lat) + Math.Abs(16.72897 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1097;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.73971 - lat) + Math.Abs(15.85975 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1098;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.32494 - lat) + Math.Abs(16.29427 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1099;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76405 - lat) + Math.Abs(16.20136 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.76318 - lat) + Math.Abs(16.19398 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(45.36125 - lat) + Math.Abs(14.30553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.25947 - lat) + Math.Abs(16.35911 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(44.91879 - lat) + Math.Abs(13.81344 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(46.0521 - lat) + Math.Abs(16.17264 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1105;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Vranjic", "15", 43.53333, 16.46667);
case 1: return new CityInfo("Županja", "18", 45.0775, 18.6975);
case 2: return new CityInfo("Žumberak", "20", 45.75, 15.43333);
case 3: return new CityInfo("Žrnovo", "03", 42.95111, 17.11417);
case 4: return new CityInfo("Žrnovnica", "15", 43.52111, 16.55917);
case 5: return new CityInfo("Žminj", "04", 45.14278, 13.90889);
case 6: return new CityInfo("Zmajevac", "10", 45.80188, 18.80879);
case 7: return new CityInfo("Zlatar", "07", 46.09417, 16.07083);
case 8: return new CityInfo("Žiškovec", "09", 46.44944, 16.43361);
case 9: return new CityInfo("Sveti Ivan Zelina", "20", 45.95611, 16.24611);
case 10: return new CityInfo("Ždralovi", "01", 45.87639, 16.875);
case 11: return new CityInfo("Zdenci Brdovečki", "20", 45.86667, 15.75);
case 12: return new CityInfo("Zdenci", "17", 45.58917, 17.95028);
case 13: return new CityInfo("Ždala", "06", 46.16687, 17.14485);
case 14: return new CityInfo("Zbelava", "16", 46.28444, 16.40917);
case 15: return new CityInfo("Zaton", "19", 44.22056, 15.17361);
case 16: return new CityInfo("Zaton", "13", 43.78944, 15.82528);
case 17: return new CityInfo("Zaton", "03", 42.69083, 18.03806);
case 18: return new CityInfo("Zasadbreg", "09", 46.45194, 16.40917);
case 19: return new CityInfo("Žarovnica", "16", 46.25556, 16.03639);
case 20: return new CityInfo("Zaprešić", "20", 45.85639, 15.80778);
case 21: return new CityInfo("Žakanje", "05", 45.6, 15.35);
case 22: return new CityInfo("Zagvozd", "15", 43.3975, 17.05694);
case 23: return new CityInfo("Žagrović", "13", 44.06454, 16.16765);
case 24: return new CityInfo("Dubrava", "21", 45.83361, 16.06361);
case 25: return new CityInfo("Zagreb", "21", 45.81444, 15.97798);
case 26: return new CityInfo("Zadvorsko", "21", 45.71978, 15.9088);
case 27: return new CityInfo("Zadvarje", "15", 43.43139, 16.88972);
case 28: return new CityInfo("Zadubravlje", "02", 45.16361, 18.15444);
case 29: return new CityInfo("Zadar", "19", 44.11578, 15.22514);
case 30: return new CityInfo("Sveti Križ Začretje", "07", 46.08083, 15.91111);
case 31: return new CityInfo("Zabok", "07", 46.02944, 15.915);
case 32: return new CityInfo("Sveti Ivan Žabno", "06", 45.94611, 16.61333);
case 33: return new CityInfo("Žabno", "14", 45.5, 16.35);
case 34: return new CityInfo("Vukšić", "19", 43.94444, 15.72528);
case 35: return new CityInfo("Vukovina", "20", 45.68333, 16.11667);
case 36: return new CityInfo("Vukovar", "18", 45.35161, 19.00225);
case 37: return new CityInfo("Vukosavljevica", "17", 45.87778, 17.23222);
case 38: return new CityInfo("Vuka", "10", 45.43389, 18.505);
case 39: return new CityInfo("Vrvari", "04", 45.22444, 13.635);
case 40: return new CityInfo("Vrsi", "19", 44.26472, 15.2325);
case 41: return new CityInfo("Vrsar", "04", 45.14917, 13.60528);
case 42: return new CityInfo("Vrpolje", "02", 45.21056, 18.40556);
case 43: return new CityInfo("Vrlika", "15", 43.90828, 16.3983);
case 44: return new CityInfo("Vrhovine", "08", 44.85167, 15.41917);
case 45: return new CityInfo("Vrh", "12", 45.05012, 14.52976);
case 46: return new CityInfo("Vrgorac", "15", 43.20583, 17.37111);
case 47: return new CityInfo("Gvozd", "14", 45.35305, 15.86563);
case 48: return new CityInfo("Vrbovsko", "12", 45.36861, 15.07833);
case 49: return new CityInfo("Vrbovec", "20", 45.88333, 16.42167);
case 50: return new CityInfo("Vrbova", "02", 45.21861, 17.57778);
case 51: return new CityInfo("Vrboska", "15", 43.18222, 16.67083);
case 52: return new CityInfo("Vrbnik", "12", 45.07583, 14.6725);
case 53: return new CityInfo("Vrbje", "02", 45.1875, 17.41917);
case 54: return new CityInfo("Vrbica", "10", 45.30639, 18.55806);
case 55: return new CityInfo("Vrbanovec", "16", 46.265, 16.52);
case 56: return new CityInfo("Vrbanja", "18", 44.98139, 18.92722);
case 57: return new CityInfo("Vratišinec", "09", 46.47806, 16.45778);
case 58: return new CityInfo("Seget Vranjica", "15", 43.50999, 16.18704);
case 59: return new CityInfo("Voloder", "14", 45.54806, 16.67889);
case 60: return new CityInfo("Vojnić", "05", 45.32361, 15.69861);
case 61: return new CityInfo("Vodostaj", "05", 45.50556, 15.58);
case 62: return new CityInfo("Vodnjan", "04", 44.95944, 13.85167);
case 63: return new CityInfo("Vođinci", "18", 45.27556, 18.60972);
case 64: return new CityInfo("Vodice", "13", 43.76083, 15.78278);
case 65: return new CityInfo("Voćin", "17", 45.61778, 17.54778);
case 66: return new CityInfo("Vladislavci", "10", 45.45944, 18.57417);
case 67: return new CityInfo("Vižinada", "04", 45.32944, 13.75861);
case 68: return new CityInfo("Visoko", "16", 46.09028, 16.325);
case 69: return new CityInfo("Višnjevac", "10", 45.56861, 18.61389);
case 70: return new CityInfo("Visignano", "04", 45.27639, 13.72083);
case 71: return new CityInfo("Viškovci", "10", 45.345, 18.46222);
case 72: return new CityInfo("Vis", "15", 43.06194, 16.18306);
case 73: return new CityInfo("Virovitica", "17", 45.83194, 17.38389);
case 74: return new CityInfo("Virje", "06", 46.06722, 16.99);
case 75: return new CityInfo("Vir", "19", 44.30306, 15.08528);
case 76: return new CityInfo("Vinogradi Ludbreški", "16", 46.23333, 16.58333);
case 77: return new CityInfo("Vinkuran", "04", 44.83611, 13.86222);
case 78: return new CityInfo("Vinkovci", "18", 45.28833, 18.80472);
case 79: return new CityInfo("Vinišće", "15", 43.48972, 16.11306);
case 80: return new CityInfo("Vinica", "16", 46.33611, 16.14944);
case 81: return new CityInfo("Vinež", "04", 45.09806, 14.10694);
case 82: return new CityInfo("Viljevo", "10", 45.75139, 18.06306);
case 83: return new CityInfo("Vidrenjak", "14", 45.61083, 16.57444);
case 84: return new CityInfo("Vidovec", "16", 46.28333, 16.24111);
case 85: return new CityInfo("Vetovo", "11", 45.41611, 17.79444);
case 86: return new CityInfo("Veprinac", "12", 45.3355, 14.27562);
case 87: return new CityInfo("Veliškovci", "10", 45.69111, 18.32167);
case 88: return new CityInfo("Velimirovac", "10", 45.52361, 18.10944);
case 89: return new CityInfo("Veli Lošinj", "12", 44.51729, 14.50479);
case 90: return new CityInfo("Veliko Trojstvo", "01", 45.93556, 16.93417);
case 91: return new CityInfo("Veliko Trgovišće", "07", 46, 15.85);
case 92: return new CityInfo("Veliko Korenovo", "01", 45.85, 16.8);
case 93: return new CityInfo("Veliki Zdenci", "01", 45.67333, 17.10917);
case 94: return new CityInfo("Veliki Grđevac", "01", 45.75028, 17.0475);
case 95: return new CityInfo("Veliki Drvenik", "15", 43.45, 16.15);
case 96: return new CityInfo("Veliki Bukovec", "16", 46.29444, 16.71306);
case 97: return new CityInfo("Veliki Bastaji", "01", 45.64528, 17.32833);
case 98: return new CityInfo("Velika Ves", "07", 46.12644, 15.89297);
case 99: return new CityInfo("Velika Trnovitica", "01", 45.6825, 16.95389);
case 100: return new CityInfo("Velika Rakovica", "20", 45.76667, 15.71667);
case 101: return new CityInfo("Velika Pisanica", "01", 45.8016, 17.06551);
case 102: return new CityInfo("Velika Ostrna", "20", 45.78752, 16.28139);
case 103: return new CityInfo("Velika Mlaka", "20", 45.73639, 16.03111);
case 104: return new CityInfo("Velika Ludina", "14", 45.6, 16.6);
case 105: return new CityInfo("Velika Kopanica", "02", 45.15611, 18.39306);
case 106: return new CityInfo("Velika Gorica", "20", 45.7125, 16.07556);
case 107: return new CityInfo("Velika Črešnjevica", "17", 45.90667, 17.18083);
case 108: return new CityInfo("Velika Buna", "20", 45.63333, 16.06667);
case 109: return new CityInfo("Velika", "11", 45.45444, 17.66139);
case 110: return new CityInfo("Vela Luka", "03", 42.96333, 16.7225);
case 111: return new CityInfo("Vardarac", "10", 45.6275, 18.77056);
case 112: return new CityInfo("Varaždinske Toplice", "16", 46.20917, 16.41917);
case 113: return new CityInfo("Varaždin", "16", 46.30444, 16.33778);
case 114: return new CityInfo("Valpovo", "10", 45.66083, 18.41861);
case 115: return new CityInfo("Unešić", "13", 43.74056, 16.18972);
case 116: return new CityInfo("Umag", "04", 45.43139, 13.52389);
case 117: return new CityInfo("Uglješ", "10", 45.66278, 18.66194);
case 118: return new CityInfo("Ugljan", "19", 44.13083, 15.10306);
case 119: return new CityInfo("Udbina", "08", 44.53056, 15.76556);
case 120: return new CityInfo("Tvrđavica", "10", 45.57139, 18.67583);
case 121: return new CityInfo("Tužno", "16", 46.25667, 16.235);
case 122: return new CityInfo("Tušilović", "05", 45.39694, 15.61667);
case 123: return new CityInfo("Turopolje", "20", 45.64944, 16.14361);
case 124: return new CityInfo("Turjaci", "15", 43.65, 16.66917);
case 125: return new CityInfo("Turčišće", "09", 46.41585, 16.59605);
case 126: return new CityInfo("Turanovac", "17", 45.89361, 17.39556);
case 127: return new CityInfo("Turanj", "19", 43.97111, 15.41139);
case 128: return new CityInfo("Tuhovec", "16", 46.2, 16.45);
case 129: return new CityInfo("Tuhelj", "07", 46.07694, 15.74722);
case 130: return new CityInfo("Tugonica", "07", 46.02972, 16.10167);
case 131: return new CityInfo("Tugare", "15", 43.46667, 16.66667);
case 132: return new CityInfo("Tučepi", "15", 43.27222, 17.05444);
case 133: return new CityInfo("Trpinja", "18", 45.41917, 18.89917);
case 134: return new CityInfo("Trpanj", "03", 43.0075, 17.275);
case 135: return new CityInfo("Trogir", "15", 43.5125, 16.25167);
case 136: return new CityInfo("Trnovec Bartolovečki", "16", 46.29472, 16.39889);
case 137: return new CityInfo("Trnjani", "02", 45.1875, 18.14222);
case 138: return new CityInfo("Trnava", "10", 45.26139, 18.25306);
case 139: return new CityInfo("Trilj", "15", 43.61833, 16.72417);
case 140: return new CityInfo("Tribunj", "13", 43.75547, 15.74444);
case 141: return new CityInfo("Tribalj", "12", 45.22139, 14.67861);
case 142: return new CityInfo("Trenkovo", "11", 45.40278, 17.66333);
case 143: return new CityInfo("Trema", "06", 45.98456, 16.60034);
case 144: return new CityInfo("Tovarnik", "18", 45.165, 19.15194);
case 145: return new CityInfo("Tounj", "05", 45.25145, 15.3255);
case 146: return new CityInfo("Totovec", "09", 46.34, 16.44222);
case 147: return new CityInfo("Tordinci", "18", 45.37028, 18.795);
case 148: return new CityInfo("Torčec", "06", 46.22333, 16.88472);
case 149: return new CityInfo("Topusko", "14", 45.29306, 15.97222);
case 150: return new CityInfo("Topolovac", "14", 45.46056, 16.43583);
case 151: return new CityInfo("Tompojevci", "18", 45.23333, 19.09194);
case 152: return new CityInfo("Tomašanci", "10", 45.38639, 18.42028);
case 153: return new CityInfo("Tkon", "19", 43.91892, 15.42);
case 154: return new CityInfo("Korenica", "08", 44.74389, 15.70972);
case 155: return new CityInfo("Tinjan", "04", 45.21806, 13.83944);
case 156: return new CityInfo("Tinj", "19", 44.01924, 15.47441);
case 157: return new CityInfo("Tisno", "13", 43.80417, 15.64333);
case 158: return new CityInfo("Tenja", "10", 45.49806, 18.74722);
case 159: return new CityInfo("Tar", "04", 45.30083, 13.62528);
case 160: return new CityInfo("Svibovec Podravski", "16", 46.35639, 16.28194);
case 161: return new CityInfo("Svetvinčenat", "04", 45.08806, 13.88361);
case 162: return new CityInfo("Sveti Petar u Šumi", "04", 45.18361, 13.86833);
case 163: return new CityInfo("Sveti Petar", "05", 45.28333, 15.2);
case 164: return new CityInfo("Sveti Matej", "07", 45.96667, 16.06667);
case 165: return new CityInfo("Sveti Martin na Muri", "09", 46.52694, 16.375);
case 166: return new CityInfo("Sveti Ilija", "16", 46.24694, 16.32528);
case 167: return new CityInfo("Sveti Ðurđ", "16", 46.28444, 16.60417);
case 168: return new CityInfo("Sveta Nedjelja", "20", 45.79833, 15.78056);
case 169: return new CityInfo("Sveta Marija", "09", 46.33556, 16.74194);
case 170: return new CityInfo("Suza", "10", 45.78306, 18.775);
case 171: return new CityInfo("Sutivan", "15", 43.38583, 16.47694);
case 172: return new CityInfo("Supetarska Draga", "12", 44.7975, 14.72472);
case 173: return new CityInfo("Supetar", "15", 43.38417, 16.55083);
case 174: return new CityInfo("Sunja", "14", 45.3685, 16.56702);
case 175: return new CityInfo("Šumeće", "02", 45.07611, 17.8775);
case 176: return new CityInfo("Sulkovci", "11", 45.26806, 17.77722);
case 177: return new CityInfo("Sukošan", "19", 44.05, 15.31667);
case 178: return new CityInfo("Suhovare", "19", 44.1575, 15.4075);
case 179: return new CityInfo("Suhopolje", "17", 45.79972, 17.49917);
case 180: return new CityInfo("Sućuraj", "15", 43.12528, 17.18611);
case 181: return new CityInfo("Subotica Podravska", "06", 46.18333, 16.75);
case 182: return new CityInfo("Stružec", "14", 45.52778, 16.55417);
case 183: return new CityInfo("Strmec Podravski", "16", 46.36444, 16.21417);
case 184: return new CityInfo("Strmec", "21", 45.70843, 15.91674);
case 185: return new CityInfo("Strizivojna", "10", 45.22611, 18.42389);
case 186: return new CityInfo("Štrigova", "09", 46.50222, 16.28833);
case 187: return new CityInfo("Strelečko", "14", 45.51868, 16.38418);
case 188: return new CityInfo("Strahoninec", "09", 46.36889, 16.415);
case 189: return new CityInfo("Ston", "03", 42.83861, 17.69639);
case 190: return new CityInfo("Stobreč", "15", 43.5025, 16.52222);
case 191: return new CityInfo("Štivica", "02", 45.18389, 17.54083);
case 192: return new CityInfo("Štitar", "18", 45.09556, 18.64028);
case 193: return new CityInfo("Štefanje", "01", 45.80472, 16.72028);
case 194: return new CityInfo("Štefanec", "09", 46.36833, 16.49611);
case 195: return new CityInfo("Staro Topolje", "02", 45.19, 18.24778);
case 196: return new CityInfo("Staro Petrovo Selo", "02", 45.23083, 17.52028);
case 197: return new CityInfo("Staro Čiče", "20", 45.7, 16.11667);
case 198: return new CityInfo("Stari Perkovci", "02", 45.2175, 18.34861);
case 199: return new CityInfo("Stari Mikanovci", "18", 45.28167, 18.5425);
case 200: return new CityInfo("Stari Jankovci", "18", 45.26194, 18.91444);
case 201: return new CityInfo("Stari Gradac", "17", 45.92444, 17.29111);
case 202: return new CityInfo("Starigrad", "19", 44.29601, 15.43865);
case 203: return new CityInfo("Stari Grad", "15", 43.18472, 16.59528);
case 204: return new CityInfo("Stare Plavnice", "01", 45.9, 16.81667);
case 205: return new CityInfo("Stara Subocka", "14", 45.35528, 16.8975);
case 206: return new CityInfo("Stara Gradiška", "02", 45.14861, 17.24667);
case 207: return new CityInfo("Gradina", "17", 45.855, 17.50722);
case 208: return new CityInfo("Stankovci", "19", 43.90972, 15.69972);
case 209: return new CityInfo("Stančić", "20", 45.85, 16.28333);
case 210: return new CityInfo("Srinjine", "15", 43.48333, 16.6);
case 211: return new CityInfo("Srima", "13", 43.7475, 15.80583);
case 212: return new CityInfo("Srijemske Laze", "18", 45.23056, 18.93194);
case 213: return new CityInfo("Srebreno", "03", 42.62333, 18.19611);
case 214: return new CityInfo("Sračinec", "16", 46.32944, 16.27889);
case 215: return new CityInfo("Split", "15", 43.50891, 16.43915);
case 216: return new CityInfo("Špišić-Bukovica", "17", 45.85722, 17.29944);
case 217: return new CityInfo("Sotin", "18", 45.29806, 19.095);
case 218: return new CityInfo("Sopje", "17", 45.80111, 17.7425);
case 219: return new CityInfo("Soljani", "18", 44.95028, 18.97028);
case 220: return new CityInfo("Solin", "15", 43.5432, 16.49314);
case 221: return new CityInfo("Sokolovac", "06", 46.11083, 16.70639);
case 222: return new CityInfo("Šodolovci", "10", 45.4, 18.62028);
case 223: return new CityInfo("Šmrika", "12", 45.24972, 14.60167);
case 224: return new CityInfo("Smokvica", "03", 42.93056, 16.89639);
case 225: return new CityInfo("Slunj", "05", 45.11507, 15.58458);
case 226: return new CityInfo("Slobodnica", "02", 45.16222, 17.93278);
case 227: return new CityInfo("Slivnica", "19", 44.24306, 15.44861);
case 228: return new CityInfo("Slavonski Brod", "02", 45.16028, 18.01556);
case 229: return new CityInfo("Požega", "11", 45.34028, 17.68528);
case 230: return new CityInfo("Slatine", "15", 43.49944, 16.33333);
case 231: return new CityInfo("Slano", "03", 42.78611, 17.89194);
case 232: return new CityInfo("Slanje", "16", 46.23139, 16.54389);
case 233: return new CityInfo("Slakovec", "09", 46.40583, 16.37694);
case 234: return new CityInfo("Slakovci", "18", 45.22472, 18.95028);
case 235: return new CityInfo("Sladojevci", "17", 45.72389, 17.65861);
case 236: return new CityInfo("Škrljevo", "12", 45.32053, 14.53268);
case 237: return new CityInfo("Skradin", "13", 43.82028, 15.92361);
case 238: return new CityInfo("Skrad", "12", 45.42778, 14.91111);
case 239: return new CityInfo("Škarićevo", "07", 46.12566, 15.85001);
case 240: return new CityInfo("Škabrnje", "19", 44.09139, 15.45389);
case 241: return new CityInfo("Sivica", "09", 46.44944, 16.50333);
case 242: return new CityInfo("Sitno Donje", "13", 43.68528, 16.13111);
case 243: return new CityInfo("Šiškovci", "18", 45.19889, 18.64667);
case 244: return new CityInfo("Sisak", "14", 45.46611, 16.37833);
case 245: return new CityInfo("Široko Polje", "10", 45.40528, 18.4725);
case 246: return new CityInfo("Sirač", "01", 45.52333, 17.255);
case 247: return new CityInfo("Sinj", "15", 43.70361, 16.63944);
case 248: return new CityInfo("Sinac", "08", 44.82944, 15.33222);
case 249: return new CityInfo("Šiljakovina", "20", 45.63333, 16.01667);
case 250: return new CityInfo("Sikirevci", "02", 45.10889, 18.46444);
case 251: return new CityInfo("Sigetec Ludbreški", "16", 46.25944, 16.63889);
case 252: return new CityInfo("Sigetec", "06", 46.18833, 16.93583);
case 253: return new CityInfo("Sibinj", "02", 45.19167, 17.90806);
case 254: return new CityInfo("Šibenik", "13", 43.73429, 15.8942);
case 255: return new CityInfo("Severin", "01", 45.83502, 16.95893);
case 256: return new CityInfo("Sesvete", "21", 45.83111, 16.11639);
case 257: return new CityInfo("Šestanovac", "15", 43.45444, 16.91139);
case 258: return new CityInfo("Šenkovec", "09", 46.40889, 16.42167);
case 259: return new CityInfo("Senj", "08", 44.98944, 14.90583);
case 260: return new CityInfo("Šemovec", "16", 46.30389, 16.47056);
case 261: return new CityInfo("Semeljci", "10", 45.36056, 18.54361);
case 262: return new CityInfo("Selnik", "16", 46.26833, 16.61056);
case 263: return new CityInfo("Selnica Šćitarjevska", "20", 45.75, 16.1);
case 264: return new CityInfo("Selnica", "09", 46.49307, 16.38937);
case 265: return new CityInfo("Selnica", "07", 46.02611, 16.04476);
case 266: return new CityInfo("Selce", "12", 45.15639, 14.72111);
case 267: return new CityInfo("Selca", "15", 43.29722, 16.85083);
case 268: return new CityInfo("Sela", "14", 45.50833, 16.30474);
case 269: return new CityInfo("Satnica Ðakovačka", "10", 45.35583, 18.37806);
case 270: return new CityInfo("Satnica", "10", 45.61444, 18.48972);
case 271: return new CityInfo("Sarvaš", "10", 45.52722, 18.8375);
case 272: return new CityInfo("Šarengrad", "18", 45.23278, 19.28028);
case 273: return new CityInfo("Šaptinovci", "10", 45.57917, 18.06);
case 274: return new CityInfo("Sapci", "02", 45.17917, 18.20667);
case 275: return new CityInfo("Šandrovac", "01", 45.90556, 17.02111);
case 276: return new CityInfo("Samobor", "20", 45.80306, 15.71806);
case 277: return new CityInfo("Samatovci", "10", 45.59639, 18.50389);
case 278: return new CityInfo("Slavonski Šamac", "02", 45.06667, 18.48889);
case 279: return new CityInfo("Salinovec", "16", 46.22361, 16.16167);
case 280: return new CityInfo("Sali", "19", 43.93972, 15.16333);
case 281: return new CityInfo("Saborsko", "05", 44.98333, 15.47806);
case 282: return new CityInfo("Ružić", "13", 43.82412, 16.25668);
case 283: return new CityInfo("Ruščica", "02", 45.14667, 18.07944);
case 284: return new CityInfo("Runović", "15", 43.37667, 17.23667);
case 285: return new CityInfo("Rukavac", "12", 45.3625, 14.29444);
case 286: return new CityInfo("Rugvica", "20", 45.73611, 16.23306);
case 287: return new CityInfo("Rude", "20", 45.76667, 15.66667);
case 288: return new CityInfo("Ruda", "15", 43.6729, 16.78359);
case 289: return new CityInfo("Rubeši", "12", 45.36694, 14.34806);
case 290: return new CityInfo("Rovišće", "01", 45.94472, 16.735);
case 291: return new CityInfo("Rovinj", "04", 45.08268, 13.63457);
case 292: return new CityInfo("Rokovci", "18", 45.23111, 18.74389);
case 293: return new CityInfo("Rogoznica", "13", 43.52472, 15.97);
case 294: return new CityInfo("Rogotin", "03", 43.04917, 17.47917);
case 295: return new CityInfo("Rijeka", "12", 45.32673, 14.44241);
case 296: return new CityInfo("Ribnik", "05", 45.57944, 15.35139);
case 297: return new CityInfo("Ribnica", "20", 45.71667, 16.13333);
case 298: return new CityInfo("Rezovac", "17", 45.78333, 17.41667);
case 299: return new CityInfo("Retkovci", "18", 45.23333, 18.65306);
case 300: return new CityInfo("Rešetari", "02", 45.26232, 17.42346);
case 301: return new CityInfo("Repušnica", "14", 45.49278, 16.73083);
case 302: return new CityInfo("Remetinec", "16", 46.18528, 16.32778);
case 303: return new CityInfo("Reka", "06", 46.13028, 16.76694);
case 304: return new CityInfo("Rečica", "05", 45.51194, 15.66333);
case 305: return new CityInfo("Ražanac", "19", 44.28194, 15.34806);
case 306: return new CityInfo("Ravna Gora", "12", 45.37278, 14.93528);
case 307: return new CityInfo("Raslina", "13", 43.80639, 15.85472);
case 308: return new CityInfo("Rasinja", "06", 46.18389, 16.70667);
case 309: return new CityInfo("Raša", "04", 45.08028, 14.07889);
case 310: return new CityInfo("Rakov Potok", "20", 45.73806, 15.79722);
case 311: return new CityInfo("Rakovica", "05", 44.99315, 15.65028);
case 312: return new CityInfo("Rakovec", "20", 45.93028, 16.3225);
case 313: return new CityInfo("Rakitovica", "10", 45.71611, 18.19194);
case 314: return new CityInfo("Rakitovec", "20", 45.66667, 16.15);
case 315: return new CityInfo("Rakitje", "20", 45.79389, 15.82222);
case 316: return new CityInfo("Rajevo Selo", "18", 44.92417, 18.77722);
case 317: return new CityInfo("Radovin", "19", 44.23111, 15.38083);
case 318: return new CityInfo("Radoboj", "07", 46.16639, 15.92361);
case 319: return new CityInfo("Radakovo", "07", 45.99052, 15.7701);
case 320: return new CityInfo("Račinovci", "18", 44.86389, 18.95528);
case 321: return new CityInfo("Rabac", "04", 45.07944, 14.1575);
case 322: return new CityInfo("Rab", "12", 44.75694, 14.76083);
case 323: return new CityInfo("Pustodol", "07", 45.96905, 15.96073);
case 324: return new CityInfo("Punitovci", "10", 45.43306, 18.41639);
case 325: return new CityInfo("Punat", "12", 45.01472, 14.62889);
case 326: return new CityInfo("Pula", "04", 44.86833, 13.84806);
case 327: return new CityInfo("Puhovo", "20", 45.79096, 16.25084);
case 328: return new CityInfo("Pučišća", "15", 43.34778, 16.73389);
case 329: return new CityInfo("Prvča", "02", 45.24361, 17.35917);
case 330: return new CityInfo("Prugovac", "06", 45.97056, 17.12);
case 331: return new CityInfo("Gornji Prozor", "08", 44.84278, 15.27083);
case 332: return new CityInfo("Prkovci", "18", 45.21444, 18.61056);
case 333: return new CityInfo("Privlaka", "18", 45.19472, 18.8375);
case 334: return new CityInfo("Privlaka", "19", 44.26667, 15.13333);
case 335: return new CityInfo("Primošten", "13", 43.58632, 15.92302);
case 336: return new CityInfo("Primorski Dolac", "15", 43.63083, 16.17611);
case 337: return new CityInfo("Prikraj", "20", 45.82569, 16.3147);
case 338: return new CityInfo("Prigorje Brdovečko", "20", 45.87944, 15.73806);
case 339: return new CityInfo("Prigorec", "16", 46.19966, 16.13194);
case 340: return new CityInfo("Pridraga", "19", 44.16667, 15.56667);
case 341: return new CityInfo("Pribislavec", "09", 46.3925, 16.4825);
case 342: return new CityInfo("Prgomet", "15", 43.60631, 16.22912);
case 343: return new CityInfo("Prgomelje", "01", 45.89083, 16.75222);
case 344: return new CityInfo("Prezid", "12", 45.63722, 14.57806);
case 345: return new CityInfo("Prespa", "01", 45.86667, 16.91667);
case 346: return new CityInfo("Premantura", "04", 44.80056, 13.90861);
case 347: return new CityInfo("Prelog", "09", 46.335, 16.61556);
case 348: return new CityInfo("Osljak", "19", 44.07667, 15.20722);
case 349: return new CityInfo("Pregrada", "07", 46.16417, 15.75083);
case 350: return new CityInfo("Predavac", "01", 45.93583, 16.78333);
case 351: return new CityInfo("Praputnjak", "12", 45.29889, 14.57361);
case 352: return new CityInfo("Poznanovec", "07", 46.05096, 16.02811);
case 353: return new CityInfo("Povljana", "19", 44.34667, 15.11556);
case 354: return new CityInfo("Potravlje", "15", 43.78498, 16.56069);
case 355: return new CityInfo("Potok", "14", 45.54889, 16.59056);
case 356: return new CityInfo("Postira", "15", 43.37551, 16.63091);
case 357: return new CityInfo("Posedarje", "19", 44.21361, 15.47667);
case 358: return new CityInfo("Poreč", "04", 45.22567, 13.59511);
case 359: return new CityInfo("Popovača", "14", 45.56972, 16.625);
case 360: return new CityInfo("Popovac", "10", 45.80917, 18.65833);
case 361: return new CityInfo("Poljanica Bistranska", "20", 45.90076, 15.87584);
case 362: return new CityInfo("Poljanec", "16", 46.26667, 16.57361);
case 363: return new CityInfo("Poljane", "12", 45.31722, 14.26778);
case 364: return new CityInfo("Poljana", "11", 45.47, 16.98083);
case 365: return new CityInfo("Poličnik", "19", 44.17806, 15.37556);
case 366: return new CityInfo("Polača", "19", 44.01833, 15.5175);
case 367: return new CityInfo("Pokupsko", "20", 45.48722, 15.99333);
case 368: return new CityInfo("Pojatno", "20", 45.905, 15.80056);
case 369: return new CityInfo("Podvinje", "02", 45.19028, 18.02694);
case 370: return new CityInfo("Podturen", "09", 46.46472, 16.54306);
case 371: return new CityInfo("Podstrana", "15", 43.48668, 16.55013);
case 372: return new CityInfo("Podravske Sesvete", "06", 46.005, 17.21167);
case 373: return new CityInfo("Slatina", "17", 45.70333, 17.70278);
case 374: return new CityInfo("Potpićan", "04", 45.18889, 14.09806);
case 375: return new CityInfo("Podhum", "12", 45.38722, 14.47944);
case 376: return new CityInfo("Podgorač", "10", 45.45861, 18.22278);
case 377: return new CityInfo("Podgora", "15", 43.24333, 17.07722);
case 378: return new CityInfo("Podgajci Podravski", "10", 45.72917, 18.27056);
case 379: return new CityInfo("Podevčevo", "16", 46.20972, 16.29417);
case 380: return new CityInfo("Podcrkavlje", "02", 45.22389, 18.01);
case 381: return new CityInfo("Podbrest", "09", 46.33139, 16.54472);
case 382: return new CityInfo("Ploče", "03", 43.05611, 17.43278);
case 383: return new CityInfo("Pleternica", "11", 45.28861, 17.80639);
case 384: return new CityInfo("Plaški", "05", 45.07639, 15.36806);
case 385: return new CityInfo("Pitomača", "17", 45.95056, 17.22944);
case 386: return new CityInfo("Piškorevci", "10", 45.25528, 18.40417);
case 387: return new CityInfo("Pisarovina", "20", 45.58639, 15.85917);
case 388: return new CityInfo("Pirovac", "13", 43.81917, 15.67278);
case 389: return new CityInfo("Pićan", "04", 45.20611, 14.04278);
case 390: return new CityInfo("Petrovsko", "07", 46.16806, 15.84083);
case 391: return new CityInfo("Petrovina Turopoljska", "20", 45.7, 16.03333);
case 392: return new CityInfo("Petrovcy", "18", 45.28889, 18.94444);
case 393: return new CityInfo("Petrinja", "14", 45.4375, 16.29);
case 394: return new CityInfo("Petrijevci", "10", 45.61278, 18.53528);
case 395: return new CityInfo("Petrijanec", "16", 46.34917, 16.225);
case 396: return new CityInfo("Petrača", "03", 42.6325, 18.19306);
case 397: return new CityInfo("Petlovac", "10", 45.75833, 18.52806);
case 398: return new CityInfo("Peteranec", "06", 46.19222, 16.89167);
case 399: return new CityInfo("Perušić", "08", 44.64944, 15.38333);
case 400: return new CityInfo("Peklenica", "09", 46.49528, 16.47611);
case 401: return new CityInfo("Pazin", "04", 45.24028, 13.93667);
case 402: return new CityInfo("Pavučnjak", "20", 45.71217, 15.76366);
case 403: return new CityInfo("Pavlovec Gradečki", "20", 45.9, 16.48333);
case 404: return new CityInfo("Pašman", "19", 43.9575, 15.385);
case 405: return new CityInfo("Palovec", "09", 46.38889, 16.54778);
case 406: return new CityInfo("Palinovec", "09", 46.39722, 16.59583);
case 407: return new CityInfo("Palešnik", "01", 45.63667, 16.97611);
case 408: return new CityInfo("Pakrac", "11", 45.43639, 17.18889);
case 409: return new CityInfo("Pakoštane", "19", 43.91222, 15.50889);
case 410: return new CityInfo("Pag", "19", 44.445, 15.0575);
case 411: return new CityInfo("Pačetin", "18", 45.3725, 18.84778);
case 412: return new CityInfo("Ozalj", "05", 45.60667, 15.46194);
case 413: return new CityInfo("Otrovanec", "17", 45.92278, 17.20583);
case 414: return new CityInfo("Otok", "18", 45.14667, 18.88389);
case 415: return new CityInfo("Otok", "15", 43.68643, 16.73329);
case 416: return new CityInfo("Otočac", "08", 44.86944, 15.2375);
case 417: return new CityInfo("Ostrovo", "18", 45.34056, 18.78972);
case 418: return new CityInfo("Oštarije", "05", 45.22472, 15.27333);
case 419: return new CityInfo("Osijek", "10", 45.55111, 18.69389);
case 420: return new CityInfo("Osekovo", "14", 45.51639, 16.61667);
case 421: return new CityInfo("Orubica", "02", 45.14778, 17.45889);
case 422: return new CityInfo("Oroslavje", "07", 45.99672, 15.91507);
case 423: return new CityInfo("Orolik", "18", 45.21528, 18.98472);
case 424: return new CityInfo("Orle", "20", 45.68333, 16.23333);
case 425: return new CityInfo("Oriovac", "02", 45.16611, 17.76);
case 426: return new CityInfo("Orešje", "20", 45.81618, 15.80246);
case 427: return new CityInfo("Orehovica", "09", 46.33167, 16.50694);
case 428: return new CityInfo("Sveti Petar Orehovec", "06", 46.07556, 16.45167);
case 429: return new CityInfo("Orebić", "03", 42.9767, 17.18619);
case 430: return new CityInfo("Orašac", "03", 42.70194, 18.00778);
case 431: return new CityInfo("Orahovica", "17", 45.54, 17.88472);
case 432: return new CityInfo("Opuzen", "03", 43.01528, 17.56556);
case 433: return new CityInfo("Oprtalj", "04", 45.38167, 13.82611);
case 434: return new CityInfo("Oprisavci", "02", 45.15111, 18.22972);
case 435: return new CityInfo("Opatija", "12", 45.33658, 14.30782);
case 436: return new CityInfo("Omišalj", "12", 45.21134, 14.55495);
case 437: return new CityInfo("Omiš", "15", 43.44472, 16.68861);
case 438: return new CityInfo("Okučani", "02", 45.26034, 17.19925);
case 439: return new CityInfo("Oklaj", "13", 43.95056, 16.08222);
case 440: return new CityInfo("Ogulin", "05", 45.26611, 15.22861);
case 441: return new CityInfo("Odra Sisačka", "14", 45.5, 16.35);
case 442: return new CityInfo("Odra", "21", 45.72979, 15.9924);
case 443: return new CityInfo("Obrovac Sinjski", "15", 43.74083, 16.67972);
case 444: return new CityInfo("Obrovac", "19", 44.20056, 15.68222);
case 445: return new CityInfo("Obrezina", "20", 45.76667, 16.1);
case 446: return new CityInfo("Oborovo", "20", 45.68278, 16.25694);
case 447: return new CityInfo("Obedišće", "20", 45.63306, 16.55528);
case 448: return new CityInfo("Nuštar", "18", 45.3325, 18.84139);
case 449: return new CityInfo("Novska", "14", 45.34056, 16.97694);
case 450: return new CityInfo("Novo Selo Rok", "09", 46.42839, 16.46215);
case 451: return new CityInfo("Novo Selo na Dravi", "09", 46.33083, 16.4325);
case 452: return new CityInfo("Novoseljani", "01", 45.88333, 16.88333);
case 453: return new CityInfo("Novoselec", "20", 45.6525, 16.53639);
case 454: return new CityInfo("Novo Čiče", "20", 45.7, 16.11667);
case 455: return new CityInfo("Novi Vinodolski", "12", 45.12806, 14.78889);
case 456: return new CityInfo("Novi Mikanovci", "18", 45.28722, 18.59139);
case 457: return new CityInfo("Novi Marof", "16", 46.16194, 16.33028);
case 458: return new CityInfo("Novi Jankovci", "18", 45.24, 18.89611);
case 459: return new CityInfo("Novigrad Podravski", "06", 46.07806, 16.95389);
case 460: return new CityInfo("Novigrad", "04", 45.315, 13.55806);
case 461: return new CityInfo("Novigrad", "19", 44.18389, 15.55417);
case 462: return new CityInfo("Novi Golubovec", "07", 46.17252, 15.9809);
case 463: return new CityInfo("Nova Subocka", "14", 45.37194, 16.92083);
case 464: return new CityInfo("Nova Rača", "01", 45.79694, 16.95361);
case 465: return new CityInfo("Novalja", "08", 44.55778, 14.88667);
case 466: return new CityInfo("Novakovec", "09", 46.45167, 16.57278);
case 467: return new CityInfo("Novaki Bistranski", "20", 45.88484, 15.86228);
case 468: return new CityInfo("Nova Kapela", "02", 45.19889, 17.63917);
case 469: return new CityInfo("Nova Gradiška", "02", 45.255, 17.38306);
case 470: return new CityInfo("Nova Bukovica", "17", 45.66472, 17.76694);
case 471: return new CityInfo("Njivice", "12", 45.15806, 14.53861);
case 472: return new CityInfo("Nijemci", "18", 45.14028, 19.03556);
case 473: return new CityInfo("Nerežišće", "15", 43.33111, 16.57861);
case 474: return new CityInfo("Neorić", "15", 43.68056, 16.52111);
case 475: return new CityInfo("Negoslavci", "18", 45.27944, 18.99667);
case 476: return new CityInfo("Nedeščina", "04", 45.14, 14.11194);
case 477: return new CityInfo("Nedeljanec", "16", 46.28778, 16.28333);
case 478: return new CityInfo("Nedelišće", "09", 46.37583, 16.3875);
case 479: return new CityInfo("Našice", "10", 45.48861, 18.08778);
case 480: return new CityInfo("Narta", "01", 45.83278, 16.78611);
case 481: return new CityInfo("Nard", "10", 45.66306, 18.48417);
case 482: return new CityInfo("Mursko Središće", "09", 46.50944, 16.44111);
case 483: return new CityInfo("Murvica", "19", 44.14722, 15.32417);
case 484: return new CityInfo("Murter", "13", 43.82043, 15.58988);
case 485: return new CityInfo("Mundanije", "12", 44.77111, 14.7625);
case 486: return new CityInfo("Mrzović", "10", 45.32639, 18.59278);
case 487: return new CityInfo("Mrkopalj", "12", 45.31556, 14.85528);
case 488: return new CityInfo("Mravince", "15", 43.53333, 16.52194);
case 489: return new CityInfo("Mraclin", "20", 45.66667, 16.09556);
case 490: return new CityInfo("Možđenec", "16", 46.15, 16.35);
case 491: return new CityInfo("Motovun", "04", 45.33667, 13.82861);
case 492: return new CityInfo("Podravska Moslavina", "10", 45.78608, 17.98339);
case 493: return new CityInfo("Mošćenička Draga", "12", 45.23778, 14.25222);
case 494: return new CityInfo("Molvice", "20", 45.76836, 15.75774);
case 495: return new CityInfo("Molve", "06", 46.10917, 17.03167);
case 496: return new CityInfo("Mokošica", "03", 42.67556, 18.09028);
case 497: return new CityInfo("Mlini", "03", 42.62306, 18.20722);
case 498: return new CityInfo("Mirkovci", "18", 45.26972, 18.85111);
case 499: return new CityInfo("Ðulovac", "01", 45.66611, 17.43333);
case 500: return new CityInfo("Milna", "15", 43.32667, 16.45083);
case 501: return new CityInfo("Mikleuš", "17", 45.61861, 17.80389);
case 502: return new CityInfo("Mihovljan", "09", 46.40861, 16.44806);
case 503: return new CityInfo("Mihovljan", "07", 46.13306, 15.97222);
case 504: return new CityInfo("Mihaljevci", "11", 45.31722, 17.87278);
case 505: return new CityInfo("Mičevec", "20", 45.75, 16.06667);
case 506: return new CityInfo("Metković", "03", 43.05417, 17.64833);
case 507: return new CityInfo("Medulin", "04", 44.8225, 13.935);
case 508: return new CityInfo("Mece", "10", 45.61889, 18.72056);
case 509: return new CityInfo("Matulji", "12", 45.36167, 14.325);
case 510: return new CityInfo("Maruševec", "16", 46.28889, 16.18306);
case 511: return new CityInfo("Čepinski Martinci", "10", 45.51083, 18.46917);
case 512: return new CityInfo("Martin", "10", 45.49222, 18.06667);
case 513: return new CityInfo("Martijanec", "16", 46.26583, 16.54);
case 514: return new CityInfo("Markušica", "18", 45.37389, 18.70583);
case 515: return new CityInfo("Markovac Našički", "10", 45.49389, 18.12556);
case 516: return new CityInfo("Marjanci", "10", 45.66694, 18.29222);
case 517: return new CityInfo("Marinići", "12", 45.365, 14.39389);
case 518: return new CityInfo("Marinci", "18", 45.34, 18.89944);
case 519: return new CityInfo("Marina", "15", 43.51472, 16.10639);
case 520: return new CityInfo("Marija Gorica", "20", 45.91097, 15.7277);
case 521: return new CityInfo("Marija Bistrica", "07", 46.00611, 16.11111);
case 522: return new CityInfo("Marčelji", "12", 45.39611, 14.38944);
case 523: return new CityInfo("Marčana", "04", 44.95528, 13.95389);
case 524: return new CityInfo("Marčan", "16", 46.32917, 16.14806);
case 525: return new CityInfo("Malinska", "12", 45.12417, 14.52828);
case 526: return new CityInfo("Mali Lošinj", "12", 44.53056, 14.46861);
case 527: return new CityInfo("Mali Bukovec", "16", 46.28306, 16.73917);
case 528: return new CityInfo("Mala Subotica", "09", 46.37616, 16.52893);
case 529: return new CityInfo("Mala Rakovica", "20", 45.78333, 15.71667);
case 530: return new CityInfo("Mala Gorica", "14", 45.47373, 16.24414);
case 531: return new CityInfo("Mala Erpenja", "07", 46.09609, 15.78516);
case 532: return new CityInfo("Makarska", "15", 43.29694, 17.01778);
case 533: return new CityInfo("Majerje", "16", 46.33333, 16.25);
case 534: return new CityInfo("Mačkovec", "09", 46.42417, 16.43361);
case 535: return new CityInfo("Macinec", "09", 46.39361, 16.32833);
case 536: return new CityInfo("Mače", "07", 46.09472, 16.03528);
case 537: return new CityInfo("Lužani", "02", 45.16806, 17.70694);
case 538: return new CityInfo("Lupoglav", "20", 45.79639, 16.34639);
case 539: return new CityInfo("Lumbarda", "03", 42.92278, 17.16722);
case 540: return new CityInfo("Lukoran", "19", 44.10306, 15.15889);
case 541: return new CityInfo("Lukavec", "20", 45.70444, 15.99);
case 542: return new CityInfo("Lukač", "17", 45.8725, 17.41944);
case 543: return new CityInfo("Luka", "20", 45.95795, 15.81954);
case 544: return new CityInfo("Lug", "10", 45.66222, 18.77583);
case 545: return new CityInfo("Ludbreg", "16", 46.25194, 16.61472);
case 546: return new CityInfo("Lučko", "21", 45.76111, 15.87028);
case 547: return new CityInfo("Sveti Lovreč", "04", 45.17583, 13.74194);
case 548: return new CityInfo("Lovreć", "15", 43.48761, 16.98632);
case 549: return new CityInfo("Lovran", "12", 45.29194, 14.27417);
case 550: return new CityInfo("Lovinac", "08", 44.39139, 15.68556);
case 551: return new CityInfo("Lovas", "18", 45.22639, 19.17111);
case 552: return new CityInfo("Lopatinec", "09", 46.43333, 16.38333);
case 553: return new CityInfo("Lopar", "12", 44.8325, 14.73028);
case 554: return new CityInfo("Lonjica", "20", 45.855, 16.33);
case 555: return new CityInfo("Lokvičič", "15", 43.46345, 17.09155);
case 556: return new CityInfo("Lokve", "12", 45.35889, 14.74861);
case 557: return new CityInfo("Loborika", "04", 44.91528, 13.90556);
case 558: return new CityInfo("Lobor", "07", 46.15278, 16.06778);
case 559: return new CityInfo("Ljupina", "02", 45.2175, 17.38278);
case 560: return new CityInfo("Ljubešćica", "16", 46.16667, 16.38333);
case 561: return new CityInfo("Ližnjan", "04", 44.82833, 13.95694);
case 562: return new CityInfo("Lišane Ostrovičke", "19", 43.96861, 15.77417);
case 563: return new CityInfo("Lipik", "11", 45.41139, 17.15222);
case 564: return new CityInfo("Martinska Ves", "14", 45.58368, 16.37617);
case 565: return new CityInfo("Ličko Lešće", "08", 44.80472, 15.32472);
case 566: return new CityInfo("Lički Osik", "08", 44.60389, 15.42472);
case 567: return new CityInfo("Lič", "12", 45.27904, 14.71906);
case 568: return new CityInfo("Levanjska Varoš", "10", 45.31556, 18.18361);
case 569: return new CityInfo("Lepoglava", "16", 46.21056, 16.03556);
case 570: return new CityInfo("Lekenik", "14", 45.58556, 16.21139);
case 571: return new CityInfo("Legrad", "06", 46.2975, 16.85667);
case 572: return new CityInfo("Lećevica", "15", 43.64191, 16.34954);
case 573: return new CityInfo("Laz Bistrički", "07", 45.96667, 16.1);
case 574: return new CityInfo("Lastovo", "03", 42.76757, 16.89708);
case 575: return new CityInfo("Lasovac", "01", 45.85167, 17.03);
case 576: return new CityInfo("Laslovo", "10", 45.415, 18.69611);
case 577: return new CityInfo("Lasinja", "05", 45.52806, 15.85911);
case 578: return new CityInfo("Lanišće", "04", 45.40722, 14.11639);
case 579: return new CityInfo("Ladimirevci", "10", 45.62556, 18.44861);
case 580: return new CityInfo("Labin", "04", 45.095, 14.11972);
case 581: return new CityInfo("Kutjevo", "11", 45.42611, 17.8825);
case 582: return new CityInfo("Kutinska Slatina", "14", 45.51667, 16.78333);
case 583: return new CityInfo("Kutina", "14", 45.475, 16.78194);
case 584: return new CityInfo("Kuterevo", "08", 44.82528, 15.14083);
case 585: return new CityInfo("Kuševac", "10", 45.34778, 18.42889);
case 586: return new CityInfo("Kuršanec", "09", 46.33028, 16.40167);
case 587: return new CityInfo("Kupljenovo", "20", 45.92918, 15.80589);
case 588: return new CityInfo("Kupinec", "20", 45.65861, 15.78694);
case 589: return new CityInfo("Kupari", "03", 42.62028, 18.19139);
case 590: return new CityInfo("Kumrovec", "07", 46.0775, 15.67556);
case 591: return new CityInfo("Kula Norinska", "03", 43.03111, 17.605);
case 592: return new CityInfo("Kukuljanovo", "12", 45.32556, 14.54);
case 593: return new CityInfo("Kučiće", "15", 43.43333, 16.8);
case 594: return new CityInfo("Kuče", "20", 45.67694, 16.145);
case 595: return new CityInfo("Kućan Marof", "16", 46.28944, 16.37222);
case 596: return new CityInfo("Kruševo", "19", 44.18333, 15.65);
case 597: return new CityInfo("Kruševica", "02", 45.0775, 18.48278);
case 598: return new CityInfo("Kršan", "04", 45.17333, 14.13861);
case 599: return new CityInfo("Krnjak", "05", 45.33333, 15.6);
case 600: return new CityInfo("Krk", "12", 45.02744, 14.57542);
case 601: return new CityInfo("Križpolje", "08", 45.02111, 15.16528);
case 602: return new CityInfo("Križevci", "06", 46.02194, 16.5425);
case 603: return new CityInfo("Križ", "20", 45.665, 16.52333);
case 604: return new CityInfo("Krištanovec", "09", 46.44417, 16.4525);
case 605: return new CityInfo("Kravarsko", "20", 45.58333, 16.05);
case 606: return new CityInfo("Krasica", "12", 45.30972, 14.55556);
case 607: return new CityInfo("Krašić", "20", 45.65583, 15.51778);
case 608: return new CityInfo("Krapinske Toplice", "07", 46.09333, 15.84333);
case 609: return new CityInfo("Krapina", "07", 46.16083, 15.87889);
case 610: return new CityInfo("Kraljevica", "12", 45.27395, 14.5683);
case 611: return new CityInfo("Kraljevec na Sutli", "07", 45.99106, 15.7247);
case 612: return new CityInfo("Kožino", "19", 44.17056, 15.19556);
case 613: return new CityInfo("Kozice", "17", 45.68333, 17.73333);
case 614: return new CityInfo("Kozarevac", "06", 45.92889, 17.11722);
case 615: return new CityInfo("Kozarac", "10", 45.71917, 18.67611);
case 616: return new CityInfo("Kovačevac", "02", 45.26667, 17.36667);
case 617: return new CityInfo("Kotoriba", "09", 46.355, 16.81806);
case 618: return new CityInfo("Košute", "15", 43.63083, 16.695);
case 619: return new CityInfo("Kostrena", "12", 45.30111, 14.50556);
case 620: return new CityInfo("Kostanje", "15", 43.44083, 16.83311);
case 621: return new CityInfo("Majur", "14", 45.255, 16.53194);
case 622: return new CityInfo("Hrvatska Kostajnica", "14", 45.23167, 16.53917);
case 623: return new CityInfo("Koška", "10", 45.54528, 18.28583);
case 624: return new CityInfo("Koritna", "10", 45.38444, 18.56556);
case 625: return new CityInfo("Korčula", "03", 42.96038, 17.13525);
case 626: return new CityInfo("Koprivnica", "06", 46.16278, 16.8275);
case 627: return new CityInfo("Kopačevo", "10", 45.60194, 18.78639);
case 628: return new CityInfo("Končanica", "01", 45.63611, 17.16639);
case 629: return new CityInfo("Komletinci", "18", 45.14972, 18.94917);
case 630: return new CityInfo("Komiža", "15", 43.04306, 16.09306);
case 631: return new CityInfo("Komin", "03", 43.04083, 17.53694);
case 632: return new CityInfo("Kolan", "19", 44.49417, 14.96139);
case 633: return new CityInfo("Kobilić", "20", 45.73333, 16.1);
case 634: return new CityInfo("Kninsko Polje", "13", 44.05139, 16.21083);
case 635: return new CityInfo("Knin", "13", 44.04063, 16.19662);
case 636: return new CityInfo("Kneževo", "10", 45.84611, 18.64278);
case 637: return new CityInfo("Kneževi Vinogradi", "10", 45.75028, 18.73306);
case 638: return new CityInfo("Kloštar Podravski", "06", 45.98111, 17.15583);
case 639: return new CityInfo("Kloštar Ivanić", "20", 45.74056, 16.42417);
case 640: return new CityInfo("Klokočevik", "02", 45.21972, 18.15028);
case 641: return new CityInfo("Klokočevac", "01", 45.91667, 16.78333);
case 642: return new CityInfo("Ključ Brdovečki", "20", 45.88278, 15.69242);
case 643: return new CityInfo("Ključ", "16", 46.16861, 16.35944);
case 644: return new CityInfo("Klis", "15", 43.55944, 16.51944);
case 645: return new CityInfo("Klinča Sela", "20", 45.69028, 15.74111);
case 646: return new CityInfo("Klenovnik", "16", 46.27028, 16.07);
case 647: return new CityInfo("Klanjec", "07", 46.04982, 15.74418);
case 648: return new CityInfo("Klana", "12", 45.44694, 14.37694);
case 649: return new CityInfo("Klakar", "02", 45.09861, 18.13222);
case 650: return new CityInfo("Kistanje", "13", 43.98278, 15.965);
case 651: return new CityInfo("Kijevo", "13", 43.97725, 16.3571);
case 652: return new CityInfo("Kešinci", "10", 45.35139, 18.55861);
case 653: return new CityInfo("Kerestinec", "20", 45.7701, 15.80864);
case 654: return new CityInfo("Kelemen", "16", 46.25667, 16.43528);
case 655: return new CityInfo("Katuni", "15", 43.46417, 16.89694);
case 656: return new CityInfo("Kaštel Sućurac", "15", 43.55028, 16.42639);
case 657: return new CityInfo("Kaštel Stari", "15", 43.55, 16.35);
case 658: return new CityInfo("Kaštel Štafilić", "15", 43.55, 16.33333);
case 659: return new CityInfo("Kaštel Novi", "15", 43.55, 16.33333);
case 660: return new CityInfo("Kaštel Lukšić", "15", 43.55528, 16.3675);
case 661: return new CityInfo("Kaštel Kambelovac", "15", 43.55, 16.38333);
case 662: return new CityInfo("Kaštelir", "04", 45.30333, 13.68528);
case 663: return new CityInfo("Kaštel Gomilica", "15", 43.55, 16.4);
case 664: return new CityInfo("Kastav", "12", 45.37528, 14.34861);
case 665: return new CityInfo("Kašina", "21", 45.91134, 16.12436);
case 666: return new CityInfo("Karojba", "04", 45.30083, 13.82306);
case 667: return new CityInfo("Karlovec Ludbreški", "16", 46.29194, 16.62944);
case 668: return new CityInfo("Karlobag", "08", 44.5275, 15.07389);
case 669: return new CityInfo("Karanac", "10", 45.76056, 18.68444);
case 670: return new CityInfo("Karakašica", "15", 43.73472, 16.63694);
case 671: return new CityInfo("Kaptol", "11", 45.43472, 17.72611);
case 672: return new CityInfo("Kapelica", "01", 45.57528, 16.89333);
case 673: return new CityInfo("Kapela", "01", 45.98833, 16.85139);
case 674: return new CityInfo("Kaniža", "02", 45.10806, 17.88611);
case 675: return new CityInfo("Kanfanar", "04", 45.12194, 13.83917);
case 676: return new CityInfo("Kamanje", "05", 45.63528, 15.39583);
case 677: return new CityInfo("Kalnik", "06", 46.12833, 16.4625);
case 678: return new CityInfo("Kalinovac", "06", 46.02944, 17.11556);
case 679: return new CityInfo("Kali", "19", 44.06278, 15.20556);
case 680: return new CityInfo("Jušići", "12", 45.3775, 14.32194);
case 681: return new CityInfo("Jurdani", "12", 45.38139, 14.31722);
case 682: return new CityInfo("Josipovac Punitovački", "10", 45.42361, 18.41833);
case 683: return new CityInfo("Josipovac", "10", 45.58278, 18.58139);
case 684: return new CityInfo("Josipdol", "05", 45.185, 15.28667);
case 685: return new CityInfo("Jezera", "13", 43.7876, 15.64108);
case 686: return new CityInfo("Ježdovec", "21", 45.78333, 15.85);
case 687: return new CityInfo("Jesenice", "19", 44.23, 15.5775);
case 688: return new CityInfo("Jesenice", "15", 43.46158, 16.60197);
case 689: return new CityInfo("Jertovec", "07", 46.03972, 16.18722);
case 690: return new CityInfo("Jerovec", "16", 46.23889, 16.10861);
case 691: return new CityInfo("Jelsa", "15", 43.16139, 16.69306);
case 692: return new CityInfo("Jelisavac", "10", 45.52889, 18.15611);
case 693: return new CityInfo("Jelenje", "12", 45.38611, 14.45111);
case 694: return new CityInfo("Javorje", "20", 45.86019, 15.76444);
case 695: return new CityInfo("Jastrebarsko", "20", 45.66833, 15.64861);
case 696: return new CityInfo("Jasenovac", "14", 45.27167, 16.91167);
case 697: return new CityInfo("Jaruge", "02", 45.11583, 18.42028);
case 698: return new CityInfo("Jarmina", "18", 45.31806, 18.72917);
case 699: return new CityInfo("Janjina", "03", 42.92528, 17.42833);
case 700: return new CityInfo("Jalžabet", "16", 46.26083, 16.475);
case 701: return new CityInfo("Jalkovec", "16", 46.28083, 16.31972);
case 702: return new CityInfo("Jakšić", "11", 45.35806, 17.76389);
case 703: return new CityInfo("Jakovlje", "20", 45.93611, 15.85559);
case 704: return new CityInfo("Jagodno", "20", 45.7, 16.15);
case 705: return new CityInfo("Jagodnjak", "10", 45.69917, 18.57694);
case 706: return new CityInfo("Jadranovo", "12", 45.23111, 14.61833);
case 707: return new CityInfo("Jablanovec", "20", 45.87583, 15.85361);
case 708: return new CityInfo("Ivanska", "01", 45.77889, 16.81194);
case 709: return new CityInfo("Ivanovec", "09", 46.36833, 16.47667);
case 710: return new CityInfo("Ivanovci Gorjanski", "10", 45.36944, 18.41361);
case 711: return new CityInfo("Ivankovo", "18", 45.28861, 18.68389);
case 712: return new CityInfo("Ivanić-Grad", "20", 45.70833, 16.39694);
case 713: return new CityInfo("Ivanec Bistranski", "20", 45.84694, 15.83139);
case 714: return new CityInfo("Ivanec", "16", 46.22306, 16.12);
case 715: return new CityInfo("Imotski", "15", 43.44667, 17.21667);
case 716: return new CityInfo("Ilova", "14", 45.45167, 16.8725);
case 717: return new CityInfo("Ilok", "18", 45.22222, 19.37694);
case 718: return new CityInfo("Ilača", "18", 45.18139, 19.09583);
case 719: return new CityInfo("Igrišće", "20", 45.96183, 15.87739);
case 720: return new CityInfo("Hvar", "15", 43.1725, 16.44278);
case 721: return new CityInfo("Husain", "14", 45.47417, 16.81306);
case 722: return new CityInfo("Hum Stubički", "07", 46.00667, 16.08917);
case 723: return new CityInfo("Hum na Sutli", "07", 46.21139, 15.69083);
case 724: return new CityInfo("Breznički Hum", "16", 46.10722, 16.27667);
case 725: return new CityInfo("Hrženica", "16", 46.29861, 16.57444);
case 726: return new CityInfo("Hrvace", "15", 43.76333, 16.615);
case 727: return new CityInfo("Hreljin Ogulinski", "05", 45.29667, 15.18139);
case 728: return new CityInfo("Hreljin", "12", 45.2825, 14.59917);
case 729: return new CityInfo("Hrastovsko", "16", 46.24917, 16.58444);
case 730: return new CityInfo("Hrašćina", "07", 46.1125, 16.2275);
case 731: return new CityInfo("Horvati", "21", 45.7, 15.81667);
case 732: return new CityInfo("Hodošan", "09", 46.39528, 16.64389);
case 733: return new CityInfo("Hlebine", "06", 46.15694, 16.96278);
case 734: return new CityInfo("Hlapičina", "09", 46.52083, 16.40056);
case 735: return new CityInfo("Herešin", "06", 46.17972, 16.86833);
case 736: return new CityInfo("Hercegovac", "01", 45.65861, 17.01361);
case 737: return new CityInfo("Harkanovci", "10", 45.59, 18.33333);
case 738: return new CityInfo("Haganj", "20", 45.91, 16.58194);
case 739: return new CityInfo("Gunja", "18", 44.88, 18.85333);
case 740: return new CityInfo("Gundinci", "02", 45.15833, 18.49139);
case 741: return new CityInfo("Gudovac", "01", 45.88028, 16.78083);
case 742: return new CityInfo("Grubišno Polje", "01", 45.70214, 17.17268);
case 743: return new CityInfo("Grožnjan", "04", 45.37889, 13.72389);
case 744: return new CityInfo("Gromačnik", "02", 45.17944, 17.9575);
case 745: return new CityInfo("Grebaštica", "13", 43.63333, 15.98333);
case 746: return new CityInfo("Gradište", "18", 45.14806, 18.70667);
case 747: return new CityInfo("Gradići", "20", 45.7, 16.05);
case 748: return new CityInfo("Gradec", "20", 45.91111, 16.48278);
case 749: return new CityInfo("Gradac", "11", 45.31306, 17.81528);
case 750: return new CityInfo("Gradac", "15", 43.10583, 17.34167);
case 751: return new CityInfo("Gračišće", "04", 45.21889, 14.01056);
case 752: return new CityInfo("Gračec", "20", 45.83333, 16.31667);
case 753: return new CityInfo("Gračac", "19", 44.29916, 15.84752);
case 754: return new CityInfo("Grabovac", "10", 45.69722, 18.74);
case 755: return new CityInfo("Grab", "15", 43.64694, 16.76139);
case 756: return new CityInfo("Gospić", "08", 44.54611, 15.37472);
case 757: return new CityInfo("Okrug Gornji", "15", 43.49473, 16.26531);
case 758: return new CityInfo("Gornji Mihaljevec", "09", 46.42864, 16.33328);
case 759: return new CityInfo("Gornji Laduč", "20", 45.88409, 15.71268);
case 760: return new CityInfo("Gornji Kraljevec", "09", 46.46667, 16.47056);
case 761: return new CityInfo("Gornji Kneginec", "16", 46.25051, 16.37555);
case 762: return new CityInfo("Gornji Karin", "19", 44.13598, 15.63423);
case 763: return new CityInfo("Gornji Hrašćan", "09", 46.37806, 16.34861);
case 764: return new CityInfo("Gornji Desinec", "20", 45.69299, 15.69157);
case 765: return new CityInfo("Gornji Bogičevci", "02", 45.25944, 17.23611);
case 766: return new CityInfo("Gornje Vratno", "16", 46.35917, 16.15444);
case 767: return new CityInfo("Podbablje", "15", 43.39314, 17.17953);
case 768: return new CityInfo("Gornje Plavnice", "01", 45.93333, 16.86667);
case 769: return new CityInfo("Gornje Ladanje", "16", 46.31167, 16.16806);
case 770: return new CityInfo("Gornje Komarevo", "14", 45.41222, 16.42194);
case 771: return new CityInfo("Gornje Jesenje", "07", 46.20639, 15.9125);
case 772: return new CityInfo("Gornja Vrba", "02", 45.15528, 18.06556);
case 773: return new CityInfo("Gornja Voća", "16", 46.3154, 16.07635);
case 774: return new CityInfo("Gornja Stubica", "07", 45.97519, 16.01931);
case 775: return new CityInfo("Gornja Pušća", "20", 45.92859, 15.77165);
case 776: return new CityInfo("Gornja Lomnica", "20", 45.71667, 16);
case 777: return new CityInfo("Gornja Jelenska", "14", 45.59944, 16.69944);
case 778: return new CityInfo("Gornja Greda", "20", 45.81217, 16.32156);
case 779: return new CityInfo("Gornja Gračenica", "14", 45.51278, 16.69583);
case 780: return new CityInfo("Gornja Bistra", "20", 45.91667, 15.9);
case 781: return new CityInfo("Gorjani", "10", 45.39889, 18.37222);
case 782: return new CityInfo("Goričan", "09", 46.38417, 16.68083);
case 783: return new CityInfo("Gorica", "04", 45.14167, 14.01528);
case 784: return new CityInfo("Gola", "06", 46.19583, 17.05806);
case 785: return new CityInfo("Gojanec", "16", 46.28778, 16.30306);
case 786: return new CityInfo("Glogovac", "06", 46.11556, 16.87444);
case 787: return new CityInfo("Glina", "14", 45.33806, 16.08806);
case 788: return new CityInfo("Gerovo", "12", 45.51472, 14.64222);
case 789: return new CityInfo("Generalski Stol", "05", 45.34778, 15.38306);
case 790: return new CityInfo("Gata", "15", 43.46667, 16.7);
case 791: return new CityInfo("Gat", "10", 45.70611, 18.32556);
case 792: return new CityInfo("Gašinci", "10", 45.33472, 18.31639);
case 793: return new CityInfo("Garešnica", "01", 45.57444, 16.94139);
case 794: return new CityInfo("Gardinovec", "09", 46.42694, 16.5575);
case 795: return new CityInfo("Garčin", "02", 45.18278, 18.18306);
case 796: return new CityInfo("Galovac", "19", 44.07139, 15.39333);
case 797: return new CityInfo("Galižana", "04", 44.93167, 13.86861);
case 798: return new CityInfo("Galgovo", "20", 45.73333, 15.75);
case 799: return new CityInfo("Gala", "15", 43.715, 16.72694);
case 800: return new CityInfo("Gaboš", "18", 45.35306, 18.73611);
case 801: return new CityInfo("Fužine", "12", 45.30528, 14.71556);
case 802: return new CityInfo("Funtana", "04", 45.17472, 13.605);
case 803: return new CityInfo("Sveti Filip i Jakov", "19", 43.96472, 15.43);
case 804: return new CityInfo("Feričanci", "10", 45.52889, 17.97583);
case 805: return new CityInfo("Ferdinandovac", "06", 46.05, 17.2);
case 806: return new CityInfo("Fažana", "04", 44.92742, 13.80349);
case 807: return new CityInfo("Ervenik", "13", 44.09944, 15.94528);
case 808: return new CityInfo("Ernestinovo", "10", 45.45194, 18.65917);
case 809: return new CityInfo("Erdut", "10", 45.52639, 19.06028);
case 810: return new CityInfo("Eminovci", "11", 45.35667, 17.73056);
case 811: return new CityInfo("Dvor", "14", 45.07306, 16.37083);
case 812: return new CityInfo("Ðurmanec", "07", 46.19639, 15.84083);
case 813: return new CityInfo("Đurđevac", "06", 46.04111, 17.06972);
case 814: return new CityInfo("Ðurđenovac", "10", 45.54333, 18.04583);
case 815: return new CityInfo("Dunjkovec", "09", 46.39, 16.37361);
case 816: return new CityInfo("Dugo Selo Lukačko", "17", 45.86361, 17.45056);
case 817: return new CityInfo("Dugo Selo", "20", 45.80611, 16.24444);
case 818: return new CityInfo("Dugopolje", "15", 43.58056, 16.60278);
case 819: return new CityInfo("Dugi Rat", "15", 43.44611, 16.63972);
case 820: return new CityInfo("Duga Resa", "05", 45.42861, 15.48833);
case 821: return new CityInfo("Duće", "15", 43.44278, 16.66833);
case 822: return new CityInfo("Dubrovnik", "03", 42.64125, 18.10909);
case 823: return new CityInfo("Dubrovčan", "07", 46.05203, 15.80014);
case 824: return new CityInfo("Dubravice", "13", 43.85306, 15.93889);
case 825: return new CityInfo("Dubravica", "20", 45.95, 15.73333);
case 826: return new CityInfo("Dubrava", "20", 45.83777, 16.53751);
case 827: return new CityInfo("Duboševica", "10", 45.88944, 18.69667);
case 828: return new CityInfo("Hrvatska Dubica", "14", 45.19111, 16.80028);
case 829: return new CityInfo("Družbinec", "16", 46.35028, 16.22472);
case 830: return new CityInfo("Drnje", "06", 46.20694, 16.91694);
case 831: return new CityInfo("Drniš", "13", 43.8625, 16.15556);
case 832: return new CityInfo("Novo Virje", "06", 46.09139, 17.15167);
case 833: return new CityInfo("Drenovci", "18", 44.92056, 18.91222);
case 834: return new CityInfo("Drenova", "12", 45.35, 14.43028);
case 835: return new CityInfo("Drenje", "10", 45.38111, 18.28194);
case 836: return new CityInfo("Dražice", "12", 45.39083, 14.47028);
case 837: return new CityInfo("Draž", "10", 45.84222, 18.78861);
case 838: return new CityInfo("Drage", "19", 43.88944, 15.54083);
case 839: return new CityInfo("Draganići", "05", 45.6, 15.6);
case 840: return new CityInfo("Dragalić", "02", 45.24417, 17.28861);
case 841: return new CityInfo("Zemunik Donji", "19", 44.10667, 15.38056);
case 842: return new CityInfo("Donji Vidovec", "09", 46.32917, 16.78667);
case 843: return new CityInfo("Donji Seget", "15", 43.51667, 16.23333);
case 844: return new CityInfo("Donji Proložac", "15", 43.46972, 17.15639);
case 845: return new CityInfo("Donji Miholjac", "10", 45.76083, 18.16722);
case 846: return new CityInfo("Donji Mihaljevec", "09", 46.33528, 16.71444);
case 847: return new CityInfo("Donji Lapac", "08", 44.55306, 15.96194);
case 848: return new CityInfo("Donji Laduč", "20", 45.88333, 15.73333);
case 849: return new CityInfo("Donji Kućan", "16", 46.28028, 16.39361);
case 850: return new CityInfo("Donji Kraljevec", "09", 46.36611, 16.65278);
case 851: return new CityInfo("Donji Kneginec", "16", 46.25944, 16.38444);
case 852: return new CityInfo("Donji Hrašćan", "09", 46.41222, 16.62528);
case 853: return new CityInfo("Donji Desinec", "20", 45.68222, 15.70889);
case 854: return new CityInfo("Donji Andrijevci", "02", 45.18833, 18.29972);
case 855: return new CityInfo("Donje Orešje", "20", 46, 16.25);
case 856: return new CityInfo("Donje Makojišće", "16", 46.15333, 16.28472);
case 857: return new CityInfo("Donje Ladanje", "16", 46.3, 16.16667);
case 858: return new CityInfo("Donja Zelina", "20", 45.9096, 16.23024);
case 859: return new CityInfo("Donja Zdenčina", "20", 45.66667, 15.76667);
case 860: return new CityInfo("Donja Vrba", "02", 45.16583, 18.10667);
case 861: return new CityInfo("Donja Voća", "16", 46.30083, 16.105);
case 862: return new CityInfo("Donja Višnjica", "16", 46.3, 16.01667);
case 863: return new CityInfo("Donja Stubica", "07", 45.98333, 15.96667);
case 864: return new CityInfo("Donja Pušća", "20", 45.91667, 15.77778);
case 865: return new CityInfo("Donja Pačetina", "07", 46.09136, 15.8822);
case 866: return new CityInfo("Donja Motičina", "10", 45.49472, 18.02417);
case 867: return new CityInfo("Donja Lomnica", "20", 45.71194, 16.02694);
case 868: return new CityInfo("Donja Kupčina", "20", 45.55056, 15.81222);
case 869: return new CityInfo("Donja Gračenica", "14", 45.495, 16.67944);
case 870: return new CityInfo("Donja Dubrava", "09", 46.31472, 16.81194);
case 871: return new CityInfo("Brela", "15", 43.36889, 16.93417);
case 872: return new CityInfo("Donja Bistra", "20", 45.90778, 15.85444);
case 873: return new CityInfo("Domaslovec", "20", 45.80834, 15.75306);
case 874: return new CityInfo("Domašinec", "09", 46.4325, 16.6);
case 875: return new CityInfo("Domagović", "20", 45.63167, 15.64028);
case 876: return new CityInfo("Doljani", "01", 45.5675, 17.22528);
case 877: return new CityInfo("Dobrinj", "12", 45.12667, 14.60333);
case 878: return new CityInfo("Dežanovac", "01", 45.57056, 17.08667);
case 879: return new CityInfo("Desinić", "07", 46.14861, 15.66861);
case 880: return new CityInfo("Delnice", "12", 45.40083, 14.79972);
case 881: return new CityInfo("Ðelekovec", "06", 46.24861, 16.86667);
case 882: return new CityInfo("Dekanovec", "09", 46.44861, 16.58472);
case 883: return new CityInfo("Debeljak", "19", 44.05111, 15.36472);
case 884: return new CityInfo("Deanovec", "20", 45.69528, 16.48194);
case 885: return new CityInfo("Davor", "02", 45.11528, 17.51639);
case 886: return new CityInfo("Daruvar", "01", 45.59056, 17.225);
case 887: return new CityInfo("Darda", "10", 45.62806, 18.69972);
case 888: return new CityInfo("Dalj", "10", 45.48438, 18.9861);
case 889: return new CityInfo("Đakovo", "10", 45.30833, 18.41056);
case 890: return new CityInfo("Sveti Petar Čvrstec", "06", 46.00245, 16.66489);
case 891: return new CityInfo("Cvetković", "20", 45.65139, 15.65222);
case 892: return new CityInfo("Cubinec", "06", 45.98333, 16.56667);
case 893: return new CityInfo("Crno", "19", 44.11417, 15.29111);
case 894: return new CityInfo("Črnkovci", "10", 45.7075, 18.295);
case 895: return new CityInfo("Črnec Biškupečki", "16", 46.26667, 16.35);
case 896: return new CityInfo("Crnac", "17", 45.69611, 17.93722);
case 897: return new CityInfo("Crikvenica", "12", 45.17722, 14.69278);
case 898: return new CityInfo("Cret Bizovački", "10", 45.57556, 18.4125);
case 899: return new CityInfo("Cres", "12", 44.96092, 14.41246);
case 900: return new CityInfo("Čovići", "08", 44.82778, 15.30111);
case 901: return new CityInfo("Civljane", "13", 43.95, 16.4);
case 902: return new CityInfo("Cista Provo", "15", 43.50333, 16.94778);
case 903: return new CityInfo("Cirkvena", "06", 45.93167, 16.66083);
case 904: return new CityInfo("Cirkovljan", "09", 46.34444, 16.64944);
case 905: return new CityInfo("Čibača", "03", 42.62889, 18.17111);
case 906: return new CityInfo("Cetingrad", "05", 45.15972, 15.73944);
case 907: return new CityInfo("Cestica", "16", 46.37167, 16.12528);
case 908: return new CityInfo("Cerovlje", "04", 45.27806, 14.01222);
case 909: return new CityInfo("Cernik", "12", 45.34361, 14.50222);
case 910: return new CityInfo("Cernik", "02", 45.28861, 17.38194);
case 911: return new CityInfo("Cerna", "18", 45.18194, 18.68944);
case 912: return new CityInfo("Cerić", "18", 45.31139, 18.85611);
case 913: return new CityInfo("Ćeralije", "17", 45.61917, 17.68583);
case 914: return new CityInfo("Čepin", "10", 45.52361, 18.56333);
case 915: return new CityInfo("Čeminac", "10", 45.68639, 18.6675);
case 916: return new CityInfo("Čehovec", "09", 46.36472, 16.62056);
case 917: return new CityInfo("Čazma", "01", 45.74818, 16.6139);
case 918: return new CityInfo("Cavtat", "03", 42.58111, 18.21806);
case 919: return new CityInfo("Čavle", "12", 45.35194, 14.48389);
case 920: return new CityInfo("Čara", "03", 42.93833, 16.93472);
case 921: return new CityInfo("Čakovec", "09", 46.38444, 16.43389);
case 922: return new CityInfo("Čajkovci", "02", 45.195, 18.36472);
case 923: return new CityInfo("Čaglin", "11", 45.34972, 17.98972);
case 924: return new CityInfo("Čađavica", "17", 45.74417, 17.85472);
case 925: return new CityInfo("Čačinci", "17", 45.60389, 17.87028);
case 926: return new CityInfo("Cabuna", "17", 45.75389, 17.57806);
case 927: return new CityInfo("Buzet", "04", 45.40944, 13.96667);
case 928: return new CityInfo("Buševec", "20", 45.63444, 16.11972);
case 929: return new CityInfo("Bušetina", "17", 45.89694, 17.35556);
case 930: return new CityInfo("Bunjani", "20", 45.7, 16.5);
case 931: return new CityInfo("Bukovlje", "02", 45.18528, 18.07);
case 932: return new CityInfo("Buković", "19", 44.03333, 15.63333);
case 933: return new CityInfo("Buje", "04", 45.41, 13.66194);
case 934: return new CityInfo("Budrovci", "10", 45.27111, 18.44861);
case 935: return new CityInfo("Budinšćina", "07", 46.12894, 16.20595);
case 936: return new CityInfo("Budimci", "10", 45.465, 18.32278);
case 937: return new CityInfo("Budaševo", "14", 45.47472, 16.43667);
case 938: return new CityInfo("Budančevica", "06", 45.98333, 17.15);
case 939: return new CityInfo("Brtonigla", "04", 45.38139, 13.62944);
case 940: return new CityInfo("Bršadin", "18", 45.36278, 18.91111);
case 941: return new CityInfo("Brodski Varoš", "02", 45.18111, 17.97861);
case 942: return new CityInfo("Brodski Stupnik", "02", 45.16778, 17.80361);
case 943: return new CityInfo("Brod Moravice", "12", 45.46528, 14.97444);
case 944: return new CityInfo("Brođanci", "10", 45.54417, 18.44944);
case 945: return new CityInfo("Bročice", "14", 45.3075, 16.95167);
case 946: return new CityInfo("Brnaze", "15", 43.68, 16.64972);
case 947: return new CityInfo("Briševo", "19", 44.16333, 15.305);
case 948: return new CityInfo("Brinje", "08", 45.0025, 15.13389);
case 949: return new CityInfo("Bribir", "12", 45.16111, 14.76472);
case 950: return new CityInfo("Brezovica", "21", 45.72919, 15.91069);
case 951: return new CityInfo("Brezovac", "01", 45.8675, 16.84083);
case 952: return new CityInfo("Breznica Našička", "10", 45.53667, 18.20556);
case 953: return new CityInfo("Breznica", "16", 46.07111, 16.27111);
case 954: return new CityInfo("Brezje", "09", 46.41861, 16.38889);
case 955: return new CityInfo("Brestovac", "11", 45.33056, 17.59694);
case 956: return new CityInfo("Brestača", "14", 45.35639, 16.95861);
case 957: return new CityInfo("Koprivnički Bregi", "06", 46.13861, 16.90583);
case 958: return new CityInfo("Bregana", "20", 45.84013, 15.68792);
case 959: return new CityInfo("Brdovec", "20", 45.86666, 15.77102);
case 960: return new CityInfo("Brckovljani", "20", 45.83333, 16.3);
case 961: return new CityInfo("Brčevec", "20", 45.86667, 16.41667);
case 962: return new CityInfo("Bratina", "20", 45.62139, 15.82722);
case 963: return new CityInfo("Branjin Vrh", "10", 45.79611, 18.61);
case 964: return new CityInfo("Bošnjaci", "18", 45.05028, 18.75556);
case 965: return new CityInfo("Bosiljevo", "05", 45.40139, 15.28833);
case 966: return new CityInfo("Borovo", "18", 45.37639, 18.96694);
case 967: return new CityInfo("Borova", "17", 45.78611, 17.46167);
case 968: return new CityInfo("Bolman", "10", 45.72111, 18.51694);
case 969: return new CityInfo("Bol", "15", 43.26194, 16.655);
case 970: return new CityInfo("Bogdanovci", "18", 45.34083, 18.93083);
case 971: return new CityInfo("Bodovaljci", "02", 45.19833, 17.44389);
case 972: return new CityInfo("Bobota", "18", 45.42111, 18.85389);
case 973: return new CityInfo("Blato", "03", 42.94083, 16.79167);
case 974: return new CityInfo("Bjelovar", "01", 45.89861, 16.84889);
case 975: return new CityInfo("Bizovac", "10", 45.59278, 18.45889);
case 976: return new CityInfo("Bistrinci", "10", 45.69167, 18.39861);
case 977: return new CityInfo("Biskupija", "13", 44.01139, 16.23722);
case 978: return new CityInfo("Biškupec Zelinski", "20", 45.96194, 16.2425);
case 979: return new CityInfo("Biograd na Moru", "19", 43.94333, 15.45194);
case 980: return new CityInfo("Bilje", "10", 45.60694, 18.74389);
case 981: return new CityInfo("Bilice", "13", 43.78869, 15.87473);
case 982: return new CityInfo("Bijelo Brdo", "10", 45.51722, 18.87083);
case 983: return new CityInfo("Bicko Selo", "02", 45.16694, 18.19139);
case 984: return new CityInfo("Bibinje", "19", 44.07288, 15.28396);
case 985: return new CityInfo("Beretinec", "16", 46.25, 16.3);
case 986: return new CityInfo("Berek", "01", 45.73833, 16.83028);
case 987: return new CityInfo("Beravci", "02", 45.15139, 18.43028);
case 988: return new CityInfo("Benkovac", "19", 44.03444, 15.61278);
case 989: return new CityInfo("Beničanci", "10", 45.63861, 18.17667);
case 990: return new CityInfo("Beljevina", "10", 45.56444, 18.01389);
case 991: return new CityInfo("Belišće", "10", 45.68028, 18.40583);
case 992: return new CityInfo("Beli Manastir", "10", 45.77, 18.60361);
case 993: return new CityInfo("Belica", "09", 46.40417, 16.51833);
case 994: return new CityInfo("Beletinec", "16", 46.21898, 16.30783);
case 995: return new CityInfo("Beketinci", "10", 45.45528, 18.4775);
case 996: return new CityInfo("Bednja", "16", 46.23056, 15.98278);
case 997: return new CityInfo("Bedenica", "20", 46.03333, 16.24278);
case 998: return new CityInfo("Bedenec", "16", 46.24028, 16.07194);
case 999: return new CityInfo("Bedekovčina", "07", 46.04111, 15.99639);
case 1000: return new CityInfo("Bebrina", "02", 45.09833, 17.83417);
case 1001: return new CityInfo("Batrina", "02", 45.18944, 17.66639);
case 1002: return new CityInfo("Batina", "10", 45.84611, 18.85);
case 1003: return new CityInfo("Baška Voda", "15", 43.35694, 16.95028);
case 1004: return new CityInfo("Baška", "12", 44.97028, 14.75333);
case 1005: return new CityInfo("Bartolovec", "16", 46.29806, 16.44111);
case 1006: return new CityInfo("Barilović", "05", 45.38333, 15.55);
case 1007: return new CityInfo("Barban", "04", 45.06444, 14.01361);
case 1008: return new CityInfo("Baranjsko Petrovo Selo", "10", 45.75556, 18.47028);
case 1009: return new CityInfo("Bapska", "18", 45.1975, 19.26);
case 1010: return new CityInfo("Banova Jaruga", "14", 45.44167, 16.905);
case 1011: return new CityInfo("Banjole", "04", 44.825, 13.86611);
case 1012: return new CityInfo("Banjol", "12", 44.75, 14.78333);
case 1013: return new CityInfo("Bale", "04", 45.04056, 13.78361);
case 1014: return new CityInfo("Bakić", "17", 45.74111, 17.68694);
case 1015: return new CityInfo("Bakar", "12", 45.30861, 14.53028);
case 1016: return new CityInfo("Badljevina", "11", 45.51167, 17.19278);
case 1017: return new CityInfo("Babino Polje", "03", 42.73333, 17.56194);
case 1018: return new CityInfo("Babina Greda", "18", 45.11722, 18.53694);
case 1019: return new CityInfo("Antunovac", "10", 45.49083, 18.675);
case 1020: return new CityInfo("Antin", "18", 45.38167, 18.75111);
case 1021: return new CityInfo("Andrijaševci", "18", 45.22472, 18.73806);
case 1022: return new CityInfo("Andraševec", "07", 45.9879, 15.94331);
case 1023: return new CityInfo("Aljmaš", "10", 45.52889, 18.95056);
case 1024: return new CityInfo("Adžamovci", "02", 45.24778, 17.465);
case 1025: return new CityInfo("Adamovec", "21", 45.90485, 16.16376);
case 1026: return new CityInfo("Zvekovica", "03", 42.57667, 18.23917);
case 1027: return new CityInfo("Mala Gorica", "20", 45.76667, 15.78333);
case 1028: return new CityInfo("Kladje", "20", 45.78333, 15.73333);
case 1029: return new CityInfo("Jankomir", "21", 45.79167, 15.9);
case 1030: return new CityInfo("Stenjevec", "21", 45.80846, 15.88245);
case 1031: return new CityInfo("Bestovje", "20", 45.80833, 15.81667);
case 1032: return new CityInfo("Novi Zagreb", "21", 45.78333, 15.98333);
case 1033: return new CityInfo("Plano", "15", 43.54419, 16.27968);
case 1034: return new CityInfo("Brodarica", "13", 43.68, 15.91972);
case 1035: return new CityInfo("Zagorska Sela", "07", 46.09694, 15.635);
case 1036: return new CityInfo("Buzdohanj", "12", 45.34528, 14.48833);
case 1037: return new CityInfo("Otrić-Seoci", "03", 43.15861, 17.45083);
case 1038: return new CityInfo("Staševica", "03", 43.13889, 17.42556);
case 1039: return new CityInfo("Donji Vinjani", "15", 43.44613, 17.24064);
case 1040: return new CityInfo("Vukojevci", "10", 45.47833, 18.15556);
case 1041: return new CityInfo("Vedrine", "15", 43.62278, 16.74417);
case 1042: return new CityInfo("Godinjak", "02", 45.23694, 17.49583);
case 1043: return new CityInfo("Netretić", "05", 45.50889, 15.41333);
case 1044: return new CityInfo("Donji Kukuruzari", "14", 45.26639, 16.48333);
case 1045: return new CityInfo("Mastrinka", "15", 43.5125, 16.27722);
case 1046: return new CityInfo("Lipovljani", "14", 45.39667, 16.88972);
case 1047: return new CityInfo("Draškovec", "09", 46.35056, 16.67667);
case 1048: return new CityInfo("Žarovnica", "16", 46.23833, 16.0575);
case 1049: return new CityInfo("Lobor", "07", 46.14861, 16.05889);
case 1050: return new CityInfo("Kukljica", "19", 44.03472, 15.24556);
case 1051: return new CityInfo("Preko", "19", 44.08111, 15.1875);
case 1052: return new CityInfo("Madžarevo", "16", 46.16778, 16.30583);
case 1053: return new CityInfo("Koprivnički Ivanec", "06", 46.20278, 16.81667);
case 1054: return new CityInfo("Podgradina", "19", 44.18389, 15.48778);
case 1055: return new CityInfo("Farkaševac", "20", 45.87944, 16.64083);
case 1056: return new CityInfo("Nin", "19", 44.24139, 15.17833);
case 1057: return new CityInfo("Stari Grad", "19", 44.43, 15.06222);
case 1058: return new CityInfo("Popovača", "08", 44.63917, 15.17917);
case 1059: return new CityInfo("Stubička Slatina", "07", 45.97639, 15.87306);
case 1060: return new CityInfo("Kampor", "12", 44.775, 14.71861);
case 1061: return new CityInfo("Vranovci", "02", 45.18417, 18.09056);
case 1062: return new CityInfo("Vidovci", "11", 45.3325, 17.71472);
case 1063: return new CityInfo("Dervišaga", "11", 45.33, 17.72806);
case 1064: return new CityInfo("Bartolovci", "02", 45.18278, 17.93083);
case 1065: return new CityInfo("Borovo Selo", "18", 45.40528, 18.97583);
case 1066: return new CityInfo("Podgora", "03", 42.84861, 17.83639);
case 1067: return new CityInfo("Brašina", "03", 42.62667, 18.19833);
case 1068: return new CityInfo("Čilipi", "03", 42.54972, 18.28472);
case 1069: return new CityInfo("Zaton Doli", "03", 42.83306, 17.75111);
case 1070: return new CityInfo("Kovačić", "13", 44.04778, 16.22389);
case 1071: return new CityInfo("Čeline", "15", 43.64306, 16.57028);
case 1072: return new CityInfo("Suhač", "15", 43.71361, 16.64111);
case 1073: return new CityInfo("Kamen", "15", 43.51417, 16.51472);
case 1074: return new CityInfo("Kučine", "15", 43.5325, 16.53083);
case 1075: return new CityInfo("Stražica", "15", 43.34611, 17.10583);
case 1076: return new CityInfo("Zmijavci", "15", 43.41083, 17.20556);
case 1077: return new CityInfo("Greda", "15", 43.61528, 16.69361);
case 1078: return new CityInfo("Matijevići", "14", 45.05361, 16.36861);
case 1079: return new CityInfo("Grabovci", "15", 43.49278, 17.20111);
case 1080: return new CityInfo("Kraj", "15", 43.14083, 17.27694);
case 1081: return new CityInfo("Grubine", "15", 43.42986, 17.16292);
case 1082: return new CityInfo("Vlaka", "03", 42.99917, 17.52417);
case 1083: return new CityInfo("Krvavac", "03", 43.02194, 17.58389);
case 1084: return new CityInfo("Korenica", "02", 45.22472, 18.16556);
case 1085: return new CityInfo("Brijest", "10", 45.52056, 18.67194);
case 1086: return new CityInfo("Livana", "10", 45.5286, 18.60106);
case 1087: return new CityInfo("Posavski Bregi", "20", 45.67972, 16.35361);
case 1088: return new CityInfo("Hrastelnica", "14", 45.50222, 16.4175);
case 1089: return new CityInfo("Červar-Porat", "04", 45.27194, 13.59722);
case 1090: return new CityInfo("Karlovac", "05", 45.49167, 15.55);
case 1091: return new CityInfo("Centar", "21", 45.81313, 15.97753);
case 1092: return new CityInfo("Stubičke Toplice", "07", 45.97585, 15.93238);
case 1093: return new CityInfo("Viškovo", "12", 45.37572, 14.384);
case 1094: return new CityInfo("Lazina Čička", "20", 45.72626, 16.12544);
case 1095: return new CityInfo("Velika Kosnica", "20", 45.76094, 16.08081);
case 1096: return new CityInfo("Poljana Čička", "20", 45.68313, 16.18003);
case 1097: return new CityInfo("Stanići", "15", 43.41408, 16.72897);
case 1098: return new CityInfo("Donji Stupnik", "20", 45.73971, 15.85975);
case 1099: return new CityInfo("Hrašćica", "16", 46.32494, 16.29427);
case 1100: return new CityInfo("Jalševec Nartski", "20", 45.76405, 16.20136);
case 1101: return new CityInfo("Struga Nartska", "20", 45.76318, 16.19398);
case 1102: return new CityInfo("Mihotići", "12", 45.36125, 14.30553);
case 1103: return new CityInfo("Turčin", "16", 46.25947, 16.35911);
case 1104: return new CityInfo("Valbandon", "04", 44.91879, 13.81344);
default: return new CityInfo("Konjšćina", "07", 46.0521, 16.17264);

                                    }                                        
                                }
                            
                        }
                    }
                