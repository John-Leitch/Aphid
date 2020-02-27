
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
                                    public const string Country = "CM";
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
                            
                                        var cur = (Math.Abs(5.53333 - lat) + Math.Abs(12.31667 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(3.51667 - lat) + Math.Abs(15.05 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.86667 - lat) + Math.Abs(11.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.34107 - lat) + Math.Abs(15.23288 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.45697 - lat) + Math.Abs(9.96822 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.38333 - lat) + Math.Abs(10.06667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.96667 - lat) + Math.Abs(10.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.075 - lat) + Math.Abs(9.36005 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.36667 - lat) + Math.Abs(12.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.46504 - lat) + Math.Abs(12.62843 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.4022 - lat) + Math.Abs(14.1698 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.93333 - lat) + Math.Abs(11.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.36667 - lat) + Math.Abs(11.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.6724 - lat) + Math.Abs(14.1786 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(8.4756 - lat) + Math.Abs(13.24097 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.3839 - lat) + Math.Abs(13.50231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.63911 - lat) + Math.Abs(9.67987 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.6 - lat) + Math.Abs(11.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.01667 - lat) + Math.Abs(11.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.98333 - lat) + Math.Abs(11.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.16667 - lat) + Math.Abs(11.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.45 - lat) + Math.Abs(11.63333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.51667 - lat) + Math.Abs(12.03333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.9547 - lat) + Math.Abs(9.9404 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.23333 - lat) + Math.Abs(10.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.3299 - lat) + Math.Abs(9.4185 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.95 - lat) + Math.Abs(11.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.25 - lat) + Math.Abs(11.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.32765 - lat) + Math.Abs(13.58472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.23343 - lat) + Math.Abs(10.61532 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.76667 - lat) + Math.Abs(10.83333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.04065 - lat) + Math.Abs(14.92501 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.68333 - lat) + Math.Abs(12.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.96667 - lat) + Math.Abs(11.51667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.2898 - lat) + Math.Abs(9.4103 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.0913 - lat) + Math.Abs(9.3144 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.9479 - lat) + Math.Abs(8.8724 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.63972 - lat) + Math.Abs(9.77694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(11.04611 - lat) + Math.Abs(14.14011 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.74244 - lat) + Math.Abs(13.80227 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.33333 - lat) + Math.Abs(10.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.58333 - lat) + Math.Abs(12.8 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.39757 - lat) + Math.Abs(14.43626 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.12181 - lat) + Math.Abs(9.96143 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.51667 - lat) + Math.Abs(14.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.62611 - lat) + Math.Abs(10.25421 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.01667 - lat) + Math.Abs(10 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.78333 - lat) + Math.Abs(11.38333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.5016 - lat) + Math.Abs(9.5671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.58333 - lat) + Math.Abs(13.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.45 - lat) + Math.Abs(11.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.51667 - lat) + Math.Abs(11.5 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.59095 - lat) + Math.Abs(14.31593 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.8428 - lat) + Math.Abs(9.8217 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.75132 - lat) + Math.Abs(9.3137 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.57535 - lat) + Math.Abs(14.45483 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.35 - lat) + Math.Abs(10.61667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.7182 - lat) + Math.Abs(9.7351 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.23333 - lat) + Math.Abs(10.73333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.02356 - lat) + Math.Abs(9.20607 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.05828 - lat) + Math.Abs(13.66605 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.2 - lat) + Math.Abs(10.66667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.6363 - lat) + Math.Abs(9.4469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.93725 - lat) + Math.Abs(9.90765 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.86846 - lat) + Math.Abs(13.88205 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(12.07689 - lat) + Math.Abs(15.03063 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.96667 - lat) + Math.Abs(12.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.08303 - lat) + Math.Abs(11.4905 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.10917 - lat) + Math.Abs(14.45083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.1 - lat) + Math.Abs(10.65 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.9333 - lat) + Math.Abs(13.94671 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.88333 - lat) + Math.Abs(14.55 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(9.30143 - lat) + Math.Abs(13.39771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.25 - lat) + Math.Abs(10.26667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.50803 - lat) + Math.Abs(10.6325 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.72662 - lat) + Math.Abs(10.89865 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.4685 - lat) + Math.Abs(9.8818 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.08333 - lat) + Math.Abs(11.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.1 - lat) + Math.Abs(11.9 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.65 - lat) + Math.Abs(10.76667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.8 - lat) + Math.Abs(10.13333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.9 - lat) + Math.Abs(11.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.44397 - lat) + Math.Abs(10.05332 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.23333 - lat) + Math.Abs(13.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.04827 - lat) + Math.Abs(9.70428 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.83333 - lat) + Math.Abs(14.7 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.76667 - lat) + Math.Abs(9.98333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.38333 - lat) + Math.Abs(13.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.1787 - lat) + Math.Abs(9.6561 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.25 - lat) + Math.Abs(10.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.15342 - lat) + Math.Abs(9.24231 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.07142 - lat) + Math.Abs(9.68177 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(10.7336 - lat) + Math.Abs(14.60928 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.6 - lat) + Math.Abs(14.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.57728 - lat) + Math.Abs(13.68459 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.13333 - lat) + Math.Abs(10.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(7.05 - lat) + Math.Abs(14.43333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.93333 - lat) + Math.Abs(13.3 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.6819 - lat) + Math.Abs(9.3214 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.06001 - lat) + Math.Abs(10.46751 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.43333 - lat) + Math.Abs(14.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.8358 - lat) + Math.Abs(9.8553 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.75 - lat) + Math.Abs(11.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.44836 - lat) + Math.Abs(10.31355 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.19685 - lat) + Math.Abs(10.38595 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.14079 - lat) + Math.Abs(10.52535 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.37568 - lat) + Math.Abs(10.41326 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.14655 - lat) + Math.Abs(10.27545 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.4591 - lat) + Math.Abs(8.9027 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.38988 - lat) + Math.Abs(10.33014 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.9597 - lat) + Math.Abs(10.14597 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.88737 - lat) + Math.Abs(10.01176 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.47775 - lat) + Math.Abs(10.41759 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.75 - lat) + Math.Abs(11.23333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(5.15705 - lat) + Math.Abs(10.1771 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.11667 - lat) + Math.Abs(10.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.38333 - lat) + Math.Abs(11.28333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.76667 - lat) + Math.Abs(12.25 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.5 - lat) + Math.Abs(11.33333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(2.78333 - lat) + Math.Abs(10.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(3.98333 - lat) + Math.Abs(13.18333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(4.4978 - lat) + Math.Abs(9.5628 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(6.45843 - lat) + Math.Abs(11.43299 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Yoko", "11", 5.53333, 12.31667);
case 1: return new CityInfo("Yokadouma", "04", 3.51667, 15.05);
case 2: return new CityInfo("Yaoundé", "11", 3.86667, 11.51667);
case 3: return new CityInfo("Yagoua", "12", 10.34107, 15.23288);
case 4: return new CityInfo("Yabassi", "05", 4.45697, 9.96822);
case 5: return new CityInfo("Wum", "07", 6.38333, 10.06667);
case 6: return new CityInfo("Tonga", "08", 4.96667, 10.7);
case 7: return new CityInfo("Tiko", "09", 4.075, 9.36005);
case 8: return new CityInfo("Tignère", "10", 7.36667, 12.65);
case 9: return new CityInfo("Tibati", "10", 6.46504, 12.62843);
case 10: return new CityInfo("Tcholliré", "13", 8.4022, 14.1698);
case 11: return new CityInfo("Sangmélima", "14", 2.93333, 11.98333);
case 12: return new CityInfo("Saa", "11", 4.36667, 11.45);
case 13: return new CityInfo("Rey Bouba", "13", 8.6724, 14.1786);
case 14: return new CityInfo("Poli", "13", 8.4756, 13.24097);
case 15: return new CityInfo("Pitoa", "13", 9.3839, 13.50231);
case 16: return new CityInfo("Penja", "05", 4.63911, 9.67987);
case 17: return new CityInfo("Ombésa", "11", 4.6, 11.25);
case 18: return new CityInfo("Okola", "11", 4.01667, 11.38333);
case 19: return new CityInfo("Okoa", "11", 3.98333, 11.6);
case 20: return new CityInfo("Obala", "11", 4.16667, 11.53333);
case 21: return new CityInfo("Ntui", "11", 4.45, 11.63333);
case 22: return new CityInfo("Nkoteng", "11", 4.51667, 12.03333);
case 23: return new CityInfo("Nkongsamba", "05", 4.9547, 9.9404);
case 24: return new CityInfo("Njinikom", "07", 6.23333, 10.28333);
case 25: return new CityInfo("Nguti", "09", 5.3299, 9.4185);
case 26: return new CityInfo("Ngoro", "11", 4.95, 11.38333);
case 27: return new CityInfo("Ngomedzap", "11", 3.25, 11.2);
case 28: return new CityInfo("Ngaoundéré", "10", 7.32765, 13.58472);
case 29: return new CityInfo("Ngambé", "05", 4.23343, 10.61532);
case 30: return new CityInfo("Ndikiniméki", "11", 4.76667, 10.83333);
case 31: return new CityInfo("Ndelele", "04", 4.04065, 14.92501);
case 32: return new CityInfo("Nanga Eboko", "11", 4.68333, 12.36667);
case 33: return new CityInfo("Mvangué", "14", 2.96667, 11.51667);
case 34: return new CityInfo("Muyuka", "09", 4.2898, 9.4103);
case 35: return new CityInfo("Mutengene", "09", 4.0913, 9.3144);
case 36: return new CityInfo("Mundemba", "09", 4.9479, 8.8724);
case 37: return new CityInfo("Mouanko", "05", 3.63972, 9.77694);
case 38: return new CityInfo("Mora", "12", 11.04611, 14.14011);
case 39: return new CityInfo("Mokolo", "12", 10.74244, 13.80227);
case 40: return new CityInfo("Mme-Bafumen", "07", 6.33333, 10.23333);
case 41: return new CityInfo("Minta", "11", 4.58333, 12.8);
case 42: return new CityInfo("Mindif", "12", 10.39757, 14.43626);
case 43: return new CityInfo("Melong", "05", 5.12181, 9.96143);
case 44: return new CityInfo("Meïganga", "10", 6.51667, 14.3);
case 45: return new CityInfo("Mbouda", "08", 5.62611, 10.25421);
case 46: return new CityInfo("Mbengwi", "07", 6.01667, 10);
case 47: return new CityInfo("Mbankomo", "11", 3.78333, 11.38333);
case 48: return new CityInfo("Mbanga", "05", 4.5016, 9.5671);
case 49: return new CityInfo("Mbang", "04", 4.58333, 13.33333);
case 50: return new CityInfo("Mbandjok", "11", 4.45, 11.9);
case 51: return new CityInfo("Mbalmayo", "11", 3.51667, 11.5);
case 52: return new CityInfo("Maroua", "12", 10.59095, 14.31593);
case 53: return new CityInfo("Manjo", "05", 4.8428, 9.8217);
case 54: return new CityInfo("Mamfe", "09", 5.75132, 9.3137);
case 55: return new CityInfo("Makary", "12", 12.57535, 14.45483);
case 56: return new CityInfo("Maan", "14", 2.35, 10.61667);
case 57: return new CityInfo("Loum", "05", 4.7182, 9.7351);
case 58: return new CityInfo("Lolodorf", "14", 3.23333, 10.73333);
case 59: return new CityInfo("Limbe", "09", 4.02356, 9.20607);
case 60: return new CityInfo("Lagdo", "13", 9.05828, 13.66605);
case 61: return new CityInfo("Kumbo", "07", 6.2, 10.66667);
case 62: return new CityInfo("Kumba", "09", 4.6363, 9.4469);
case 63: return new CityInfo("Kribi", "14", 2.93725, 9.90765);
case 64: return new CityInfo("Koza", "12", 10.86846, 13.88205);
case 65: return new CityInfo("Kousséri", "12", 12.07689, 15.03063);
case 66: return new CityInfo("Kontcha", "10", 7.96667, 12.23333);
case 67: return new CityInfo("Bankim", "10", 6.08303, 11.4905);
case 68: return new CityInfo("Kaélé", "12", 10.10917, 14.45083);
case 69: return new CityInfo("Jakiri", "07", 6.1, 10.65);
case 70: return new CityInfo("Guider", "13", 9.9333, 13.94671);
case 71: return new CityInfo("Garoua Boulaï", "04", 5.88333, 14.55);
case 72: return new CityInfo("Garoua", "13", 9.30143, 13.39771);
case 73: return new CityInfo("Fundong", "07", 6.25, 10.26667);
case 74: return new CityInfo("Foumbot", "08", 5.50803, 10.6325);
case 75: return new CityInfo("Foumban", "08", 5.72662, 10.89865);
case 76: return new CityInfo("Fontem", "09", 5.4685, 9.8818);
case 77: return new CityInfo("Évodoula", "11", 4.08333, 11.2);
case 78: return new CityInfo("Essé", "11", 4.1, 11.9);
case 79: return new CityInfo("Eséka", "11", 3.65, 10.76667);
case 80: return new CityInfo("Edéa", "05", 3.8, 10.13333);
case 81: return new CityInfo("Ébolowa", "14", 2.9, 11.15);
case 82: return new CityInfo("Dschang", "08", 5.44397, 10.05332);
case 83: return new CityInfo("Doumé", "04", 4.23333, 13.45);
case 84: return new CityInfo("Douala", "05", 4.04827, 9.70428);
case 85: return new CityInfo("Djohong", "10", 6.83333, 14.7);
case 86: return new CityInfo("Dizangué", "05", 3.76667, 9.98333);
case 87: return new CityInfo("Dimako", "04", 4.38333, 13.56667);
case 88: return new CityInfo("Dibombari", "05", 4.1787, 9.6561);
case 89: return new CityInfo("Diang", "05", 4.25, 10.01667);
case 90: return new CityInfo("Buea", "09", 4.15342, 9.24231);
case 91: return new CityInfo("Bonabéri", "05", 4.07142, 9.68177);
case 92: return new CityInfo("Bogo", "12", 10.7336, 14.60928);
case 93: return new CityInfo("Bétaré Oya", "04", 5.6, 14.08333);
case 94: return new CityInfo("Bertoua", "04", 4.57728, 13.68459);
case 95: return new CityInfo("Belo", "07", 6.13333, 10.25);
case 96: return new CityInfo("Bélel", "10", 7.05, 14.43333);
case 97: return new CityInfo("Bélabo", "04", 4.93333, 13.3);
case 98: return new CityInfo("Bekondo", "09", 4.6819, 9.3214);
case 99: return new CityInfo("Bazou", "08", 5.06001, 10.46751);
case 100: return new CityInfo("Batouri", "04", 4.43333, 14.36667);
case 101: return new CityInfo("Batibo", "07", 5.8358, 9.8553);
case 102: return new CityInfo("Banyo", "10", 6.75, 11.81667);
case 103: return new CityInfo("Bansoa", "08", 5.44836, 10.31355);
case 104: return new CityInfo("Ngou", "08", 5.19685, 10.38595);
case 105: return new CityInfo("Bangangté", "08", 5.14079, 10.52535);
case 106: return new CityInfo("Bandjoun", "08", 5.37568, 10.41326);
case 107: return new CityInfo("Bana", "08", 5.14655, 10.27545);
case 108: return new CityInfo("Bamusso", "09", 4.4591, 8.9027);
case 109: return new CityInfo("Bamendjou", "08", 5.38988, 10.33014);
case 110: return new CityInfo("Bamenda", "07", 5.9597, 10.14597);
case 111: return new CityInfo("Bali", "07", 5.88737, 10.01176);
case 112: return new CityInfo("Bafoussam", "08", 5.47775, 10.41759);
case 113: return new CityInfo("Bafia", "11", 4.75, 11.23333);
case 114: return new CityInfo("Bafang", "08", 5.15705, 10.1771);
case 115: return new CityInfo("Babanki", "07", 6.11667, 10.25);
case 116: return new CityInfo("Ambam", "14", 2.38333, 11.28333);
case 117: return new CityInfo("Akonolinga", "11", 3.76667, 12.25);
case 118: return new CityInfo("Akono", "11", 3.5, 11.33333);
case 119: return new CityInfo("Akom II", "14", 2.78333, 10.56667);
case 120: return new CityInfo("Abong Mbang", "04", 3.98333, 13.18333);
case 121: return new CityInfo("Ndom", "05", 4.4978, 9.5628);
default: return new CityInfo("Somié", "10", 6.45843, 11.43299);

                                    }                                        
                                }
                            
                        }
                    }
                