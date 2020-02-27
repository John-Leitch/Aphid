
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
                                    public const string Country = "BD";
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
                            
                                        var cur = (Math.Abs(26.03097 - lat) + Math.Abs(88.46989 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(20.85829 - lat) + Math.Abs(92.29773 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.89154 - lat) + Math.Abs(90.40232 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.89904 - lat) + Math.Abs(91.87198 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.59311 - lat) + Math.Abs(90.14251 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.91965 - lat) + Math.Abs(89.94812 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.00146 - lat) + Math.Abs(89.32266 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.68501 - lat) + Math.Abs(88.15638 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.70817 - lat) + Math.Abs(89.07185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.45771 - lat) + Math.Abs(89.70802 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.88352 - lat) + Math.Abs(90.72898 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.92298 - lat) + Math.Abs(90.71768 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.51409 - lat) + Math.Abs(91.45491 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.17687 - lat) + Math.Abs(89.5988 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.1006 - lat) + Math.Abs(90.84989 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.374 - lat) + Math.Abs(88.60114 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.94077 - lat) + Math.Abs(90.60025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.57965 - lat) + Math.Abs(89.97521 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(26.33338 - lat) + Math.Abs(88.55777 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.29543 - lat) + Math.Abs(91.979 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.66369 - lat) + Math.Abs(88.93093 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.61352 - lat) + Math.Abs(90.50298 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.63696 - lat) + Math.Abs(90.27195 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.05783 - lat) + Math.Abs(89.87696 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.96817 - lat) + Math.Abs(89.69153 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.75636 - lat) + Math.Abs(90.40646 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.76484 - lat) + Math.Abs(90.25698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.10287 - lat) + Math.Abs(90.09841 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.48888 - lat) + Math.Abs(91.77075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.45566 - lat) + Math.Abs(89.85584 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.82257 - lat) + Math.Abs(90.52859 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.28616 - lat) + Math.Abs(89.95883 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.91719 - lat) + Math.Abs(89.44595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.24018 - lat) + Math.Abs(91.12143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.46186 - lat) + Math.Abs(91.18503 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.74664 - lat) + Math.Abs(89.25166 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.9028 - lat) + Math.Abs(89.11943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.40964 - lat) + Math.Abs(89.13801 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.11134 - lat) + Math.Abs(89.09061 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.10147 - lat) + Math.Abs(89.02734 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.12858 - lat) + Math.Abs(89.06573 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.38044 - lat) + Math.Abs(91.41299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.97372 - lat) + Math.Abs(90.22376 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.432 - lat) + Math.Abs(90.5585 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.0144 - lat) + Math.Abs(91.3966 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.0391 - lat) + Math.Abs(90.76808 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.31006 - lat) + Math.Abs(89.79113 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.7104 - lat) + Math.Abs(90.40744 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.55613 - lat) + Math.Abs(89.67097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.02475 - lat) + Math.Abs(91.51091 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.33774 - lat) + Math.Abs(90.73708 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.10787 - lat) + Math.Abs(91.97007 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.03852 - lat) + Math.Abs(91.66958 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.01472 - lat) + Math.Abs(89.43936 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.02452 - lat) + Math.Abs(88.99234 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.0524 - lat) + Math.Abs(90.9764 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.19534 - lat) + Math.Abs(92.21946 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.043 - lat) + Math.Abs(89.63094 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.51863 - lat) + Math.Abs(91.35787 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.21623 - lat) + Math.Abs(90.95002 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.65657 - lat) + Math.Abs(89.79123 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.67419 - lat) + Math.Abs(89.05377 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.15509 - lat) + Math.Abs(89.49515 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.89983 - lat) + Math.Abs(89.90326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.65 - lat) + Math.Abs(90.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.75127 - lat) + Math.Abs(89.83126 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.31988 - lat) + Math.Abs(90.16943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.53511 - lat) + Math.Abs(91.91919 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.71673 - lat) + Math.Abs(89.51194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.21824 - lat) + Math.Abs(90.35076 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.80418 - lat) + Math.Abs(88.94875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.88791 - lat) + Math.Abs(90.96792 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.7772 - lat) + Math.Abs(90.17604 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.9443 - lat) + Math.Abs(90.83005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.90725 - lat) + Math.Abs(89.21954 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.83333 - lat) + Math.Abs(91.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.25191 - lat) + Math.Abs(90.85508 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.60612 - lat) + Math.Abs(89.84064 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.62745 - lat) + Math.Abs(88.63779 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.22647 - lat) + Math.Abs(90.71275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.3384 - lat) + Math.Abs(91.83168 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.30916 - lat) + Math.Abs(90.22698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.07821 - lat) + Math.Abs(89.63262 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.49518 - lat) + Math.Abs(90.72391 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.07639 - lat) + Math.Abs(92.04955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(21.43973 - lat) + Math.Abs(92.00955 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.80979 - lat) + Math.Abs(89.56439 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.68759 - lat) + Math.Abs(90.64403 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.70497 - lat) + Math.Abs(90.37013 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.16971 - lat) + Math.Abs(89.21371 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.00644 - lat) + Math.Abs(89.2372 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.24984 - lat) + Math.Abs(89.91655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.85098 - lat) + Math.Abs(89.37108 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.85587 - lat) + Math.Abs(88.35943 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.59025 - lat) + Math.Abs(88.27444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.17097 - lat) + Math.Abs(90.20935 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.01881 - lat) + Math.Abs(90.01751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.43944 - lat) + Math.Abs(90.78291 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.83957 - lat) + Math.Abs(91.84128 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.48898 - lat) + Math.Abs(90.06273 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(22.68347 - lat) + Math.Abs(91.79058 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.77769 - lat) + Math.Abs(88.89169 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.02691 - lat) + Math.Abs(88.97592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.36537 - lat) + Math.Abs(88.83431 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.41112 - lat) + Math.Abs(88.98673 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.80562 - lat) + Math.Abs(88.62444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.67346 - lat) + Math.Abs(88.98885 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.48702 - lat) + Math.Abs(89.41592 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.7298 - lat) + Math.Abs(90.3854 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(25.3293 - lat) + Math.Abs(89.5438 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(24.96111 - lat) + Math.Abs(89.34278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.73625 - lat) + Math.Abs(90.41426 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.78758 - lat) + Math.Abs(90.16487 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.78225 - lat) + Math.Abs(90.18382 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.82037 - lat) + Math.Abs(90.12175 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.81741 - lat) + Math.Abs(90.11921 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.78789 - lat) + Math.Abs(90.16472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(23.79119 - lat) + Math.Abs(90.16972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Thākurgaon", "87", 26.03097, 88.46989);
case 1: return new CityInfo("Teknāf", "84", 20.85829, 92.29773);
case 2: return new CityInfo("Tungi", "81", 23.89154, 90.40232);
case 3: return new CityInfo("Sylhet", "86", 24.89904, 91.87198);
case 4: return new CityInfo("Dohār", "81", 23.59311, 90.14251);
case 5: return new CityInfo("Jamālpur", "H", 24.91965, 89.94812);
case 6: return new CityInfo("Shibganj", "83", 25.00146, 89.32266);
case 7: return new CityInfo("Shibganj", "83", 24.68501, 88.15638);
case 8: return new CityInfo("Sātkhira", "82", 22.70817, 89.07185);
case 9: return new CityInfo("Sirajganj", "83", 24.45771, 89.70802);
case 10: return new CityInfo("Netrakona", "H", 24.88352, 90.72898);
case 11: return new CityInfo("Narsingdi", "81", 23.92298, 90.71768);
case 12: return new CityInfo("Sandwīp", "84", 22.51409, 91.45491);
case 13: return new CityInfo("Shāhzādpur", "83", 24.17687, 89.5988);
case 14: return new CityInfo("Rāmganj", "84", 23.1006, 90.84989);
case 15: return new CityInfo("Rājshāhi", "83", 24.374, 88.60114);
case 16: return new CityInfo("Purbadhala", "H", 24.94077, 90.60025);
case 17: return new CityInfo("Pirojpur", "85", 22.57965, 89.97521);
case 18: return new CityInfo("Panchagarh", "87", 26.33338, 88.55777);
case 19: return new CityInfo("Patiya", "84", 22.29543, 91.979);
case 20: return new CityInfo("Parbatipur", "87", 25.66369, 88.93093);
case 21: return new CityInfo("Nārāyanganj", "81", 23.61352, 90.50298);
case 22: return new CityInfo("Nālchiti", "85", 22.63696, 90.27195);
case 23: return new CityInfo("Nāgarpur", "81", 24.05783, 89.87696);
case 24: return new CityInfo("Nageswari", "87", 25.96817, 89.69153);
case 25: return new CityInfo("Mymensingh", "H", 24.75636, 90.40646);
case 26: return new CityInfo("Muktāgācha", "H", 24.76484, 90.25698);
case 27: return new CityInfo("Mirzāpur", "81", 24.10287, 90.09841);
case 28: return new CityInfo("Maulavi Bāzār", "86", 24.48888, 91.77075);
case 29: return new CityInfo("Morrelgonj", "82", 22.45566, 89.85584);
case 30: return new CityInfo("Mehendiganj", "85", 22.82257, 90.52859);
case 31: return new CityInfo("Mathba", "85", 22.28616, 89.95883);
case 32: return new CityInfo("Lalmonirhat", "87", 25.91719, 89.44595);
case 33: return new CityInfo("Lākshām", "84", 23.24018, 91.12143);
case 34: return new CityInfo("Comilla", "84", 23.46186, 91.18503);
case 35: return new CityInfo("Rangpur", "87", 25.74664, 89.25166);
case 36: return new CityInfo("Kushtia", "82", 23.9028, 89.11943);
case 37: return new CityInfo("Kālīganj", "82", 23.40964, 89.13801);
case 38: return new CityInfo("Jhingergācha", "82", 23.11134, 89.09061);
case 39: return new CityInfo("Joypur Hāt", "83", 25.10147, 89.02734);
case 40: return new CityInfo("Ishurdi", "83", 24.12858, 89.06573);
case 41: return new CityInfo("Habiganj", "86", 24.38044, 91.41299);
case 42: return new CityInfo("Gaurnadi", "85", 22.97372, 90.22376);
case 43: return new CityInfo("Gafargaon", "H", 24.432, 90.5585);
case 44: return new CityInfo("Feni", "84", 23.0144, 91.3966);
case 45: return new CityInfo("Rāipur", "84", 23.0391, 90.76808);
case 46: return new CityInfo("Sarankhola", "82", 22.31006, 89.79113);
case 47: return new CityInfo("Dhaka", "81", 23.7104, 90.40744);
case 48: return new CityInfo("Chilmāri", "87", 25.55613, 89.67097);
case 49: return new CityInfo("Chhāgalnāiya", "84", 23.02475, 91.51091);
case 50: return new CityInfo("Lālmohan", "85", 22.33774, 90.73708);
case 51: return new CityInfo("Khagrachhari", "84", 23.10787, 91.97007);
case 52: return new CityInfo("Chhātak", "86", 25.03852, 91.66958);
case 53: return new CityInfo("Bhātpāra Abhaynagar", "82", 23.01472, 89.43936);
case 54: return new CityInfo("Bherāmāra", "82", 24.02452, 88.99234);
case 55: return new CityInfo("Bhairab Bāzār", "81", 24.0524, 90.9764);
case 56: return new CityInfo("Bāndarban", "84", 22.19534, 92.21946);
case 57: return new CityInfo("Kālia", "82", 23.043, 89.63094);
case 58: return new CityInfo("Baniachang", "86", 24.51863, 91.35787);
case 59: return new CityInfo("Bājitpur", "81", 24.21623, 90.95002);
case 60: return new CityInfo("Bagerhat", "82", 22.65657, 89.79123);
case 61: return new CityInfo("Badarganj", "87", 25.67419, 89.05377);
case 62: return new CityInfo("Narail", "82", 23.15509, 89.49515);
case 63: return new CityInfo("Tungipāra", "81", 22.89983, 89.90326);
case 64: return new CityInfo("Sonārgaon", "81", 23.65, 90.61667);
case 65: return new CityInfo("Sarishābāri", "H", 24.75127, 89.83126);
case 66: return new CityInfo("Sakhipur", "81", 24.31988, 90.16943);
case 67: return new CityInfo("Raojān", "84", 22.53511, 91.91919);
case 68: return new CityInfo("Phultala", "82", 22.71673, 89.51194);
case 69: return new CityInfo("Pālang", "81", 23.21824, 90.35076);
case 70: return new CityInfo("Pār Naogaon", "83", 24.80418, 88.94875);
case 71: return new CityInfo("Nabīnagar", "84", 23.88791, 90.96792);
case 72: return new CityInfo("Ramnagar", "81", 23.7772, 90.17604);
case 73: return new CityInfo("Lakshmīpur", "84", 22.9443, 90.83005);
case 74: return new CityInfo("Kesabpur", "82", 22.90725, 89.21954);
case 75: return new CityInfo("Jahedpur", "86", 24.83333, 91.65);
case 76: return new CityInfo("Hājīganj", "84", 23.25191, 90.85508);
case 77: return new CityInfo("Farīdpur", "81", 23.60612, 89.84064);
case 78: return new CityInfo("Dinājpur", "87", 25.62745, 88.63779);
case 79: return new CityInfo("Uttar Char Fasson", "82", 22.22647, 90.71275);
case 80: return new CityInfo("Chittagong", "84", 22.3384, 91.83168);
case 81: return new CityInfo("Char Bhadrāsan", "81", 23.30916, 90.22698);
case 82: return new CityInfo("Bera", "83", 24.07821, 89.63262);
case 83: return new CityInfo("Burhānuddin", "85", 22.49518, 90.72391);
case 84: return new CityInfo("Sātkania", "84", 22.07639, 92.04955);
case 85: return new CityInfo("Cox’s Bāzār", "84", 21.43973, 92.00955);
case 86: return new CityInfo("Khulna", "82", 22.80979, 89.56439);
case 87: return new CityInfo("Bhola", "85", 22.68759, 90.64403);
case 88: return new CityInfo("Barisāl", "85", 22.70497, 90.37013);
case 89: return new CityInfo("Jessore", "82", 23.16971, 89.21371);
case 90: return new CityInfo("Pābna", "83", 24.00644, 89.2372);
case 91: return new CityInfo("Tāngāil", "81", 24.24984, 89.91655);
case 92: return new CityInfo("Bogra", "83", 24.85098, 89.37108);
case 93: return new CityInfo("Pīrgaaj", "87", 25.85587, 88.35943);
case 94: return new CityInfo("Nawābganj", "83", 24.59025, 88.27444);
case 95: return new CityInfo("Mādārīpur", "81", 23.17097, 90.20935);
case 96: return new CityInfo("Sherpur", "H", 25.01881, 90.01751);
case 97: return new CityInfo("Kishorganj", "81", 24.43944, 90.78291);
case 98: return new CityInfo("Manikchari", "84", 22.83957, 91.84128);
case 99: return new CityInfo("Bhāndāria", "85", 22.48898, 90.06273);
case 100: return new CityInfo("Bibir Hat", "84", 22.68347, 91.79058);
case 101: return new CityInfo("Saidpur", "83", 25.77769, 88.89169);
case 102: return new CityInfo("Paharpur", "83", 25.02691, 88.97592);
case 103: return new CityInfo("Puthia", "83", 24.36537, 88.83431);
case 104: return new CityInfo("Natore", "83", 24.41112, 88.98673);
case 105: return new CityInfo("Ujalpur", "82", 23.80562, 88.62444);
case 106: return new CityInfo("Nowlamary", "82", 23.67346, 88.98885);
case 107: return new CityInfo("Magura", "82", 23.48702, 89.41592);
case 108: return new CityInfo("Azimpur", "81", 23.7298, 90.3854);
case 109: return new CityInfo("Gaibandha", "87", 25.3293, 89.5438);
case 110: return new CityInfo("Mahasthangarh", "83", 24.96111, 89.34278);
case 111: return new CityInfo("Paltan", "81", 23.73625, 90.41426);
case 112: return new CityInfo("Parvez Ali Hossain", "81", 23.78758, 90.16487);
case 113: return new CityInfo("Khanbaniara", "81", 23.78225, 90.18382);
case 114: return new CityInfo("Char Golora", "81", 23.82037, 90.12175);
case 115: return new CityInfo("Parvez Ali", "81", 23.81741, 90.11921);
case 116: return new CityInfo("Joymontop", "81", 23.78789, 90.16472);
default: return new CityInfo("Sayani", "81", 23.79119, 90.16972);

                                    }                                        
                                }
                            
                        }
                    }
                